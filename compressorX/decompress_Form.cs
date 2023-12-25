using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace compressorX
{
    public partial class decompress_Form : Form
    {
        public decompress_Form()
        {
            InitializeComponent();
            restAllValues();
        }

        //Rest All values
        public void restAllValues()
        {
            extraBits = 0;
            header = "";
            headerLength = 0;
            headerLengthIndex = 0;
            treeTableChar = new List<char>();
            treeTableCharCode = new List<string>();
        }

        //Read Compressed file and Create Binary File
        public int extraBits = 0;
        public string header = "";
        int headerLength = 0;
        int headerLengthIndex = 0;
        public void compressedFileToBinaryFile(StreamReader fileReader, StreamWriter binaryFileWriter)
        {
            string s = "";

            for (int i = 0; i < fileReader.BaseStream.Length; i++)
            {
                char character = (char)fileReader.Read();
                s += character;

                if (character == '\t')
                {
                    headerLengthIndex = i;

                    if (headerLengthIndex != 0)
                        headerLength = Convert.ToInt32(s);
                    else
                        headerLength = Convert.ToInt32(s);

                    break;
                }
            }

            //Read Header
            for (int i = 0; i < headerLength - 1; i++)
                header += (char)fileReader.Read();

            //Read ExtraBits
            extraBits = Convert.ToInt32(Convert.ToString((char)fileReader.Read()));

            //Read Compress Text and create Binary File(bin)
            while (!fileReader.EndOfStream)
            {
                string binaryString = charToBinary((char)fileReader.Read());
                binaryFileWriter.Write(binaryString);
            }

            //Close open files
            fileReader.Close();
            binaryFileWriter.Close();
        }

        //Reconstruct HuffmanTree
        public void ReconstructHuffmanTree(string header)
        {
            //Try to
            PriorityQueue priorityQueue = new PriorityQueue();

            for (int i = 0; i < header.Length; i++)
            {
                Node node = new Node();

                node.character = header[i];
                node.frequency = i;//charCount[i];

                node.left = null;
                node.right = null;

                priorityQueue.Enqueue(node);
            }

            Node root = null;
            int c = 0;
            while (priorityQueue.Count > 1)
            {
                c++;
                Node first = priorityQueue.Peek();
                priorityQueue.Dequeue();

                Node second = priorityQueue.Peek();
                priorityQueue.Dequeue();

                Node n = new Node();

                n.frequency = c;//first.frequency + second.frequency;
                n.character = '-';

                n.left = first;
                n.right = second;

                root = n;

                priorityQueue.Enqueue(n);
            }

            generateHuffmanCodes(root, "");
        }

        //print Huffman codes and Save into list

        List<char> treeTableChar = new List<char>();
        List<string> treeTableCharCode = new List<string>();
        public void generateHuffmanCodes(Node root, string s)
        {
            if (root.left == null && root.right == null)
            {

                treeTableChar.Add(root.character);
                treeTableCharCode.Add(s);

                return;
            }

            generateHuffmanCodes(root.left, s + "0");
            generateHuffmanCodes(root.right, s + "1");
        }


        //convert charToBinary
        public static string charToBinary(char character)
        {
            int charToACIICode = (int)Convert.ToChar(character);

            string str = Convert.ToString(charToACIICode, 2);
            int strLen = str.Length;
            string addZeros = "";

            while (strLen != 8)
            {
                addZeros += "0";
                strLen++;
            }

            return addZeros + Convert.ToString(charToACIICode, 2);
        }

        //Method Create Decompress file using Binary File
        public void binaryFileToDecompressFile(StreamReader binaryFileReader, StreamWriter decompressFileWriter)
        {
            string checkString = "";

            int removeBits;

            if (extraBits == 8)
                removeBits = 0;
            else
                removeBits = extraBits;

            for (int i = 0; i < binaryFileReader.BaseStream.Length - removeBits; i++)
            {
                checkString += (char)binaryFileReader.Read();

                if (treeTableCharCode.Contains(checkString))
                {
                    int codeTableIndex = treeTableCharCode.IndexOf(checkString);
                    decompressFileWriter.Write(treeTableChar[codeTableIndex]);
                    checkString = "";
                }
            }

            //Close Open Files
            binaryFileReader.Close();
            decompressFileWriter.Close();
        }

        private async void startDecompressFile_BTN_Click(object sender, EventArgs e)
        {
            //Check Compression Done
            bool isDecompressionDone = false;

            //Disable All Buttons
            startDecompressFile_BTN.Enabled = false;
            selectFile_BTN.Enabled = false;
            selectLoc_BTN.Enabled = false;

            //Disable FileName Textbox
            selectFileName_txtbx.Enabled = false;

            //Show ProgressBar and Please wait Text
            decompressProgressBar.Visible = true;
            Loading_LBL.Visible = true;

            await Task.Run(() =>
            {
                if (selectFile_txtBx.Text != "" && selectLoc_txtbx.Text != "" && selectFileName_txtbx.Text != "")
                {
                    string filePath = selectFile_txtBx.Text;

                    string fileContent = File.ReadAllText(filePath);

                    //Binary File Path
                    string binaryFilePath = selectLoc_txtbx.Text + "\\" + selectFileName_txtbx.Text + ".bin";

                    //Read Compressed File and write binary File
                    compressedFileToBinaryFile(new StreamReader(filePath), new StreamWriter(binaryFilePath));

                    //Reconstruct Huffman Tree
                    ReconstructHuffmanTree(header);

                    //Decompressed File Path
                    string decompressFilePath = selectLoc_txtbx.Text + "\\" + selectFileName_txtbx.Text + ".txt";

                    //Create Decompress File using Huffman code generated Binary File
                    binaryFileToDecompressFile(new StreamReader(binaryFilePath), new StreamWriter(decompressFilePath));

                    //Delete Binary(bin) File
                    File.Delete(binaryFilePath);

                    //Decompression Done
                    isDecompressionDone = true;
                }
            });

            //Hide ProgressBar and loading Text
            decompressProgressBar.Visible = false;
            Loading_LBL.Visible = false;

            //Enable All Buttons
            selectFile_BTN.Enabled = true;
            selectLoc_BTN.Enabled = true;
            startDecompressFile_BTN.Enabled = true;

            //Enable FileName Textbox
            selectFileName_txtbx.Enabled = true;

            if (selectFile_txtBx.Text != "" && selectLoc_txtbx.Text != "" && selectFileName_txtbx.Text != "" && isDecompressionDone == true)
            {
                //Sucess Message Show
                MessageBox.Show("Decompression Done!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Close Compress Form
                this.Close();
                CompressorX.isDecompressorOpen = false;
            }
        }

        private void exit_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompressorX.isDecompressorOpen = false;
        }

        private void minimized_BTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Select a File
        public void openFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "compressorX file (*.compx) | *.compx;";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                selectFile_txtBx.Text = fileDialog.FileName;
            }
        }

        private void selectFile_BTN_Click(object sender, EventArgs e)
        {
            openFile();
        }

        //Select save Location
        string SaveFolderPath = "";
        public string openSaveFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFolderPath = folderBrowserDialog.SelectedPath;
                return SaveFolderPath;
            }
            return SaveFolderPath;
        }

        private void selectLoc_BTN_Click(object sender, EventArgs e)
        {
            selectLoc_txtbx.Text = openSaveFolder();
        }

        //Mouse Drage Move Code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void mouseMoveDrag_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
