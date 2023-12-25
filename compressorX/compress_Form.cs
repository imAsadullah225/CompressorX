using System;
using System.Collections;
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
    public partial class compress_Form : Form
    {
        public compress_Form()
        {
            InitializeComponent();
            restAllValues();
        }

        //Reset All values
        public void restAllValues()
        {
            huffmanMap = "";
            charInFile = new List<char>();
            charCount = new List<int>();
            treeTableChar = new List<char>();
            treeTableCharCode = new List<string>();
        }

        //Read chararacters form file and add Different Char and there frequencies in list 
        List<char> charInFile = new List<char>();
        List<int> charCount = new List<int>();
        public void charAndFrequencyCounter(StreamReader fileReader)
        {
            while (!fileReader.EndOfStream)
            {
                char character = (char)fileReader.Read();

                if (!charInFile.Contains(character))
                {
                    charInFile.Add(character);
                    charCount.Add(1);
                }
                else
                {
                    int index = charInFile.IndexOf(character);
                    int count = charCount[index];
                    count++;
                    charCount[index] = count;
                }
            }

            //close open File
            fileReader.Close();
        }


        //Huffman Map
        string huffmanMap = "";

        //print codes and generate map

        List<char> treeTableChar = new List<char>();
        List<string> treeTableCharCode = new List<string>();
        public void printCodes(Node root, string s)
        {
            if (root.left == null && root.right == null )
            {

                treeTableChar.Add(root.character);
                treeTableCharCode.Add(s);

                return;
            }

            printCodes(root.left, s + "0");
            printCodes(root.right, s + "1");
        }


        //Huffman tree Method
        public void createhuffmanTree()
        {
            //Sort char and frequency in Acending order
            for (int i = 0; i < charCount.Count; i++)
            {
                for (int j = 0; j < charCount.Count; j++)
                {
                    if (charCount[i] < charCount[j])
                    {
                        int tempCount;
                        char tempChar;

                        tempCount = charCount[j];
                        charCount[j] = charCount[i];
                        charCount[i] = tempCount;

                        tempChar = charInFile[j];
                        charInFile[j] = charInFile[i];
                        charInFile[i] = tempChar;
                    }
                }
            }

            //Create Huffman Map
            huffmanMap += (charInFile.Count + 1).ToString() + "\t" + string.Join("", charInFile);

            //Try to
            PriorityQueue priorityQueue = new PriorityQueue();

            for (int i = 0; i < charInFile.Count; i++)
            {
                Node node = new Node();

                node.character = charInFile[i];
                node.frequency = i;//charCount[i];

                node.left = null;
                node.right = null;

                priorityQueue.Enqueue(node);
            }

            Node root = null;
            int cc = 0;

            while(priorityQueue.Count > 1)
            {
                cc++;
                Node first = priorityQueue.Peek();
                priorityQueue.Dequeue();

                Node second = priorityQueue.Peek();
                priorityQueue.Dequeue();

                Node n = new Node();

                n.frequency = cc;//first.frequency + second.frequency;
                n.character = '-';

                n.left = first;
                n.right = second;

                root = n;

                priorityQueue.Enqueue(n);
            }

            printCodes(root, "");
        }

        //Write char Huffman code Method
        public void charToHuffmanCode(StreamReader fileReader, StreamWriter binaryFileWriter)
        {
            while (!fileReader.EndOfStream)
            {
                char character = (char)fileReader.Read();

                int treeIndex = treeTableChar.IndexOf(character);

                //Write Binary(Bin) file
                binaryFileWriter.Write(treeTableCharCode[treeIndex]);
            }
            
            //Close open files
            fileReader.Close();
            binaryFileWriter.Close();
        }

        // Method create Compress file using Huffman Binary file
        public static void BinaryFileToCompressFile(StreamReader binaryFileReader, string savePath, string huffmanMap, string extraBits)
        {
            StreamWriter compressFile = new StreamWriter(savePath);

            //Write Huffman Map into File
            compressFile.Write(huffmanMap);

            //write extraBits into File
            compressFile.Write(extraBits);

            string s = "";

            while(!binaryFileReader.EndOfStream)
            {
                s += (char)binaryFileReader.Read();

                if (s.Length == 8)
                {
                    compressFile.Write((char)Convert.ToByte(s, 2));
                    s = "";
                }
            }

            if (s != "")
            {
                int strLen = s.Length;
                string addZeros = "";

                while (strLen != 8)
                {
                    addZeros += "0";
                    strLen++;
                }

                compressFile.Write((char)Convert.ToByte(s + addZeros, 2));
            }

            //close open file
            binaryFileReader.Close();
            compressFile.Close();
        }

        private async void startCompressFile_BTN_Click(object sender, EventArgs e)
        {
            //Check Compression Done
            bool isCompressionDone = false;

            //Disable All Buttons
            startCompressFile_BTN.Enabled = false;
            selectFile_BTN.Enabled = false;
            selectLoc_BTN.Enabled = false;

            //Disable FileName Textbox
            selectFileName_txtbx.Enabled = false;

            //Show ProgressBar and Please wait Text
            compressProgressBar.Visible = true;
            Loading_LBL.Visible = true;

            await Task.Run(() =>
            {
                if (selectFile_txtBx.Text != "" && selectLoc_txtbx.Text != "" && selectFileName_txtbx.Text != "")
                {
                    string filePath = selectFile_txtBx.Text;
                    
                    //call method char and its Frequency Counter
                    charAndFrequencyCounter(new StreamReader(filePath));

                    //Call Huffman tree Method
                    createhuffmanTree();

                    //Binary(Bin) file path
                    string binFilePath = selectLoc_txtbx.Text + "\\" + selectFileName_txtbx.Text + ".bin";
 
                    //call char to HuffmanCode method
                    charToHuffmanCode(new StreamReader(filePath), new StreamWriter(binFilePath));

                    //Initilize binaryFile stereaReader
                    StreamReader binaryFileReader = new StreamReader(binFilePath);

                    //Get BinaryFile Length
                    int binaryfileLength = (int)binaryFileReader.BaseStream.Length;

                    //Close binary File
                    binaryFileReader.Close();

                    //count extraBits
                    int extraBits = 8 - (binaryfileLength % 8);

                    //Compress file savePath
                    string saveFilePath = selectLoc_txtbx.Text + "\\" + selectFileName_txtbx.Text + ".compx";

                    //Write Compress File using Huffman binary file
                    BinaryFileToCompressFile(new StreamReader(binFilePath), saveFilePath, huffmanMap, extraBits.ToString());

                    //Delete Binary(Bin) file
                    File.Delete(binFilePath);

                    //Compression Done
                    isCompressionDone = true;
                }
            });

            //Hide ProgressBar and loading Text
            compressProgressBar.Visible = false;
            Loading_LBL.Visible = false;

            //Enable All Buttons
            selectFile_BTN.Enabled = true;
            selectLoc_BTN.Enabled = true;
            startCompressFile_BTN.Enabled = true;

            //Enable FileName Textbox
            selectFileName_txtbx.Enabled = true;

            if (selectFile_txtBx.Text != "" && selectLoc_txtbx.Text != "" && selectFileName_txtbx.Text != "" && isCompressionDone == true)
            {
                //Sucess Message Show
                MessageBox.Show("Compression Done!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Close Compress Form
                this.Close();
                CompressorX.isCompressorOpen = false;
            }
        }

        private void exit_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompressorX.isCompressorOpen = false;  
        }

        private void minimized_BTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Select a File
        public void openFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt) | *.txt;";

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
