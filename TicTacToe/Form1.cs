namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Button[,] _boxes = new Button[3, 3];
        private bool _xTurn = true;
        private bool _isStart = true;

        public Form1()
        {
            InitializeComponent();
            MakeBoxes();
        }

        private void MakeBoxes()
        {
            lblResult.Text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var box = new Button();
                    box.BackColor = Color.AntiqueWhite;
                    box.Width = 65;
                    box.Height = 65;
                    box.Left = 100 + j * 70;
                    box.Top = 100 + i * 70;
                    box.Click += Box_Click;
                    _boxes[i, j] = box;

                    Controls.Add(box);
                }
            }
        }

        private void Box_Click(object? sender, EventArgs e)
        {
            Button box = sender as Button;

            if (box == null) return;

            if (box.Text != "") return;

            box.Text = _xTurn ? "X" : "O";

            _xTurn = !_xTurn;

            CheckWin();
        }

        private void CheckWin()
        {
            //Check rows

            for (int i = 0; i < 3; i++)
            {
                if (_boxes[i, 0].Text != "" && _boxes[i, 0].Text == _boxes[i, 1].Text && _boxes[i, 1].Text == _boxes[i, 2].Text)
                {
                    lblResult.Text = $"{_boxes[i, 0].Text} win";
                    _isStart = false;
                    BackColor = Color.Green;

                    return;
                }
            }

            //Check column

            for (int i = 0; i < 3; i++)
            {
                if (_boxes[0, i].Text != "" && _boxes[0, i].Text == _boxes[1, i].Text && _boxes[1, i].Text == _boxes[2, i].Text)
                {
                    lblResult.Text = $"{_boxes[0, i].Text} win";
                    _isStart = false;

                    return;
                }
            }

            //Check diaqonals

            if (_boxes[0, 0].Text != "" && _boxes[0, 0].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[2, 2].Text)
            {
                lblResult.Text = $"{_boxes[0, 0].Text} win";
                _isStart = false;

                return;
            }

            if (_boxes[0, 2].Text != "" && _boxes[0, 2].Text == _boxes[1, 1].Text && _boxes[1, 1].Text == _boxes[2, 0].Text)
            {
                lblResult.Text = $"{_boxes[0, 2].Text} win";
                _isStart = false;

                return;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_boxes[i, j].Text == "")
                        return;
                }
            }


            lblResult.Text = "Draw";
            _isStart = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isStart)
                return;

            lblResult.Text = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _boxes[i, j].Text = "";
                    _boxes[i, j].BackColor = Color.AntiqueWhite;
                }
            }

            _isStart = true;
        }
    }
}
