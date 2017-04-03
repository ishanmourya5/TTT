using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TTT
{
    public partial class Form1 : Form
    {
        Socket sock;
        IPAddress peer_ip,my_ip;
        String my_ob, peer_ob;
        EndPoint epLocal, epRemote;
        int peer_no, my_no;
        byte[] buffer;
        int turn;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void connect_button_Click(object sender, EventArgs e)
        {
            //PEER IP
            peer_ip = IPAddress.Parse(peer_ip_textbox.Text);
            peer_no = Convert.ToInt32(peer_port_textbox.Text);
            //MY IP
            my_ip = IPAddress.Parse(my_ip_textbox.Text);
            my_no = Convert.ToInt32(my_port_textbox.Text);
            //SETTING VALUES
            if (peer_no > my_no)
            {
                label_turn.Text = "Friend's Turn";
                turn = peer_no;
                my_ob = "X";
                peer_ob = "O";
            }
            else
            {
                label_turn.Text = "Your Turn";
                turn = my_no;
                my_ob = "O";
                peer_ob = "X";
            }
            //CONNECTING
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);         
            epLocal = new IPEndPoint(my_ip, my_no);
            sock.Bind(epLocal);
            epRemote = new IPEndPoint(peer_ip,peer_no);
            sock.Connect(epRemote);
            buffer = new byte[1464];
            sock.BeginReceiveFrom(buffer, 0, buffer.Length,SocketFlags.None, ref epRemote,new AsyncCallback(OperatorCallBack), buffer);
            connect_button.Text = "Connected";
            connect_button.Enabled = false;
        }

        private void OperatorCallBack(IAsyncResult ar)
        {
            try
            {
                int size = sock.EndReceiveFrom(ar, ref epRemote);
                if (size > 0)
                {
                    byte[] aux = new byte[1464];
                    aux = (byte[])ar.AsyncState;
                    ASCIIEncoding enc = new ASCIIEncoding();
                    string msg = enc.GetString(aux);
                    set_button(msg);
                }
                buffer = new byte[1464];
                sock.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(OperatorCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            if (peer_no > my_no)
            {
                label_turn.Text = "Friend's Turn";
                turn = peer_no;
            }
            else
            {
                label_turn.Text = "Your Turn";
                turn = my_no;
            }
            enableall();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (turn == my_no)
            {
                Button bt = (Button)sender;
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] msg = new byte[1464];
                msg = enc.GetBytes(bt.Name);
                sock.Send(msg);
                bt.Text = my_ob;
                bt.Enabled = false;
                count++;
                check();
                turn = peer_no;
                label_turn.Text = "Friend's Turn";
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You and your Friend first connect to same WiFi/Ethernet \nEnter your IP in 'Own IP' Section\nIn case You dont know your IP:\nOpen Cmd and type 'ipconfig', the IPV4 term will be your IP\n" +
                "Enter a Random 4 Digit Number into 'Own Port'\nShare these with Your Friend and ask him to enter them into his 'Peer IP' and 'Peer Port' Boxes and Vice-Versa");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Ishan Mourya, IIEST Shibpur");
        }

        public void set_button(String s)
        {
            s.Trim();
            char[] ss = s.ToCharArray();
            if (ss[1]=='1') 
            {
                b1.Text = peer_ob;
                b1.Enabled = false;
            }
            else if (ss[1] == '2')
            {
                b2.Text = peer_ob;
                b2.Enabled = false;
            }
            else if (ss[1] == '3')
            {
                b3.Text = peer_ob;
                b3.Enabled = false;
            }
            else if (ss[1] == '4')
            {
                b4.Text = peer_ob;
                b4.Enabled = false;
            }
            else if (ss[1] == '5')
            {
                b5.Text = peer_ob;
                b5.Enabled = false;
            }
            else if (ss[1] == '6')
            {
                b6.Text = peer_ob;
                b6.Enabled = false;
            }
            else if (ss[1] == '7')
            {
                b7.Text = peer_ob;
                b7.Enabled = false;
            }
            else if (ss[1] == '8')
            {
                b8.Text = peer_ob;
                b8.Enabled = false;
            }
            else if (ss[1] == '9')
            {
                b9.Text = peer_ob;
                b9.Enabled = false;
            }
            count++;
            if (check() == false) label_turn.Text = "Your Turn";
            turn = my_no;
        }

        public bool check()
        {
            bool matchover = false;
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                matchover = true;
            }
            else if ((b4.Text == b5.Text) && (b5.Text == b6.Text) && (!b4.Enabled))
            {
                matchover = true;
            }
            else if ((b7.Text == b8.Text) && (b8.Text == b9.Text) && (!b7.Enabled))
            {
                matchover = true;
            }
            else if ((b1.Text == b4.Text) && (b4.Text == b7.Text) && (!b1.Enabled))
            {
                matchover = true;
            }
            else if ((b2.Text == b5.Text) && (b5.Text == b8.Text) && (!b2.Enabled))
            {
                matchover = true;
            }
            else if ((b3.Text == b6.Text) && (b6.Text == b9.Text) && (!b3.Enabled))
            {
                matchover = true;
            }
            else if ((b1.Text == b5.Text) && (b5.Text == b9.Text) && (!b1.Enabled))
            {
                matchover = true;
            }
            else if ((b3.Text == b5.Text) && (b5.Text == b7.Text) && (!b3.Enabled))
            {
                matchover = true;
            }
            else if (count >= 9)
            {
                MessageBox.Show("Match Draw !!!", "Match Over");
                disableall();
            }
            if (matchover)
            {
                String result;
                if (turn == my_no) result = "You Win !";
                else result = "You Loose !";
                MessageBox.Show(result);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void disableall()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }
        }

        public void enableall()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            connect_button.Enabled = false;
            connect_button.Text = "Connected";
        }
    }
}
