using System.Security.Cryptography.X509Certificates;

namespace Cursach.LoadData
{
    public struct ChartData
    {
        public ChartData() { }

        public string[] name;
        public static List<string> X = [];
        public List<List<string>> Y = [];

        public static bool operator true(List<string> X)
        {
            return X.Count != 0;
        }

        public static bool operator false(List<string> X)
        {
            return X.Count == 0;
        }
    }

    public partial class Load : Form
    {
        private ChartData result;

        public ChartData Result
        { get { return result; } }


        // part of customization region
        private void SetText(string text, Color color)
        { fileURL.Text = text; fileURL.ForeColor = color; }

        // part of get data region
        private void PostAndSaveData(string path)
        {
            try
            {
                result = new();
                switch (fileType.SelectedIndex)
                {
                    case 0:
                        string delimeter = Microsoft.VisualBasic.Interaction.InputBox("Set Delimeter (Default ;)", "Settings", ";");
                        using (var reader = new StreamReader(path))
                        {
                            if (legendsNames.Checked) result.name = reader.ReadLine().Split(delimeter);
                            while (!reader.EndOfStream)
                            {
                                string[] values = reader.ReadLine().Split(delimeter);
                                result.X.Add(values[0]);
                                int yRange = 2;
                                if (readMode.Checked) yRange = values.Length - 1;
                                List<string> tmp = [];
                                for (int i = 1; i < yRange;) { tmp.Add(values[i++]); }
                                result.Y.Add(tmp);
                            }
                        }
                        break;
                    case 1:
                        break;
                    default:
                        throw new Exception("No such file exists");
                }

            }
            catch (Exception ex )
            { MessageBox.Show($"Smt was fucked up {ex.Message}"); }
        }
    }
}