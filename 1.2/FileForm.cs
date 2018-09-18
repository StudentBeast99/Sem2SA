using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace _1._2
{
    public partial class FileForm : Form
    {
        public FileForm()
        {
            InitializeComponent();
        }
        private List<double> GetInput()
        {
            try
            {
                return new List<double>(
                    Array.ConvertAll(Input.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                    (x) => double.Parse(x)));
            }
            catch(Exception)
            {
                throw new Exception("некорректный ввод");
            }
        }
        private List<double> GetOutput()
        {
            return new List<double>(
                Array.ConvertAll(Output.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                (x) => double.Parse(x)));
        }

        private void OpenInputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    FileTools file = new FileTools(openFileDialog.FileName);
                    file.BinReaderOpen();
                    Input.Text = String.Join(" ", file.ReadBinListDouble());
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void SaveInputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> inp = GetInput();
                if (inp.Count == 0)
                {
                    MessageBox.Show("нет данных", "Error");
                    return;
                }
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.BinWriterOpen();
                    file.WriteBinList(inp);
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void OpenOutputFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(openFileDialog.FileName);
                    file.BinReaderOpen();
                    StringBuilder sb = new StringBuilder();
                    while(!file.End)
                    {
                        sb.AppendLine(String.Join(" ", file.ReadBinListDouble()));
                    }
                    Output.Text = sb.ToString();
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void SaveOutputBtn_Click(object sender, EventArgs e)
        {
            List<double> outp = GetOutput();
            if (outp.Count == 0)
            {
                MessageBox.Show("нет данных", "Error");
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileTools file = new FileTools(saveFileDialog.FileName);
                    file.BinWriterOpen();
                    file.WriteBinList(outp);
                    file.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<double> inp = GetInput();
                double min = inp[0], max = inp[0];
                int minIndex = 0, maxIndex = 0;
                for (int i = 0; i < inp.Count; i++)
                {
                    if(inp[i] < min)
                    {
                        min = inp[i];
                        minIndex = i;
                    }
                    if(inp[i] > max)
                    {
                        max = inp[i];
                        maxIndex = i;
                    }
                }
                inp[minIndex] = max;
                inp[maxIndex] = min;
                Output.Text = String.Join(" ", inp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
