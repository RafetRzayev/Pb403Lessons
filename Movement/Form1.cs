

namespace Movement
{
    public partial class Form1 : Form
    {
        private int _xSpeed = 2;
        private int _ySpeed = 2;
        private List<Button> _targets = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 10;
            MakeTargets();
        }

        private void MakeTargets()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    var target = new Button
                    {
                        BackColor = Color.Green,
                        Left = 50 + 100 * j,
                        Width = 95,
                        Top = 50 + 45 * i,
                        Height = 40
                    };

                    _targets.Add(target);
                    Controls.Add(target);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Right >= panel1.Left && button1.Left <= panel1.Right && button1.Bottom >= panel1.Top)
            {
                _xSpeed = -_xSpeed;
                _ySpeed = -_ySpeed;
            }

            if (button1.Right >= ClientSize.Width)
                _xSpeed = -_xSpeed;

            if (button1.Bottom >= ClientSize.Height)
                _ySpeed = -_ySpeed;

            if (button1.Top <= 0)
                _ySpeed = -_ySpeed;

            if (button1.Left <= 0)
                _xSpeed = -_xSpeed;

            button1.Left += _xSpeed;
            button1.Top += _ySpeed;        
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                if (panel1.Left >= 10)
                    panel1.Left -= 10;
            }
            else if (keyData == Keys.Right)
            {
                if (panel1.Right <= ClientSize.Width)
                    panel1.Left += 10;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
