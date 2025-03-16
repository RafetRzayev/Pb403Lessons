namespace SortVisualization
{
    public partial class Form1 : Form
    {
        private List<Panel> panels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            MakePanels();
        }

        private void MakePanels()
        {
            var random = new Random();

            for (int i = 0; i < 40; i++)
            {
                var panel = new Panel()
                {
                    Width = 15,
                    Height = random.Next(20, 300),
                    Left = 30 + i * 18,
                    BackColor = Color.DarkRed,
                };

                panel.Top = ClientSize.Height - panel.Height - 120;
                panels.Add(panel);

                Controls.Add(panel);
            }
        }

        private void BubbleSort()
        {
            for (int i = 0; i < panels.Count; i++)
            {
                for (int j = 0; j < panels.Count - i - 1; j++)
                {
                    if (panels[j].Height > panels[j + 1].Height)
                    {
                        var item = panels[j];
                        panels[j] = panels[j + 1];
                        panels[j + 1] = item;

                        var tmpLeft = panels[j].Left;
                        panels[j].Left = panels[j + 1].Left;
                        panels[j + 1].Left = tmpLeft;

                        Thread.Sleep(10);
                    }
                }
            }
        }

        private void SelectionSort()
        {
            int minIndex;
            for (int i = 0; i < panels.Count; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < panels.Count; j++)
                {
                    if (panels[j].Height < panels[minIndex].Height)
                    {
                        minIndex = j;
                    }
                }

                var item = panels[i];
                panels[i] = panels[minIndex];
                panels[minIndex] = item;

                var left = panels[i].Left;
                panels[i].Left = panels[minIndex].Left;
                panels[minIndex].Left = left;
                Thread.Sleep(30);
            }
        }


        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            //BubbleSort();
            SelectionSort();
        }
    }
}
