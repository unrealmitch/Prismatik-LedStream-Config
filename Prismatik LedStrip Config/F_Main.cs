using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prismatik_LedStrip_Config{
    public partial class F_Main : Form{

        int[,] leds = new int[256,4];
        int i_led = 0;
        int selected_led = 0;

        F_Preview f_preview1 = new F_Preview();
        public float scale = 2;

        //multiedit
        int[] leds_selected;

        bool me_x = false, me_y = false;        //Determine if all selected item have the same parameters
        bool me_sx = false, me_sy = false;

        public F_Main(){
            InitializeComponent();
        }

        private void preview(){
            scale = 1 + (((float)NUM_Scale.Value) / 10);
            f_preview1.Show();
            this.Focus();
            f_preview1.resize((int)(35 + int.Parse(TB_ResY.Text) / scale), (int)(15 + int.Parse(TB_ResX.Text) / scale));
            f_preview1.npixels = i_led;

            for (int i = 0; i < i_led; i++) {
                f_preview1.createPixel(i, (int)(leds[i, 0] / scale), (int)(leds[i, 1] / scale), (int)(leds[i, 2] / scale), (int)(leds[i, 3] / scale));
            }
        }

        private void BT_Add_Click(object sender, EventArgs e){
            int nleds = Int32.Parse(TB_NLeds.Text);

            int sizeX = Int32.Parse(TB_SizeX.Text), sizeY = Int32.Parse(TB_SizeY.Text);
            int posX = Int32.Parse(TB_StartX.Text), posY = Int32.Parse(TB_StartY.Text);

            int stepX = 0, stepY = 0;

            if (RB_Left.Checked){
                stepX = -sizeX;
            } else if (RB_Right.Checked) {
                stepX = sizeX;
            } else if (RB_Up.Checked) {
                stepY = -sizeY;
            } else if (RB_Down.Checked) {
                stepY = sizeY;
            }

            for (int i = 0; i < nleds; i++){
                leds[i_led,0] = posX;
                leds[i_led,1] = posY;
                leds[i_led,2] = sizeX;
                leds[i_led,3] = sizeY;

                posX += stepX;
                posY += stepY;
                i_led++;

                LB_Leds.Items.Add(i_led);
            }

            //TB_StartX.Text = (posX - stepX).ToString();
            //TB_StartY.Text = (posY - stepY).ToString();

            preview();
        }

        private void LB_Leds_SelectedIndexChanged(object sender, EventArgs e) {
            int nselect = LB_Leds.SelectedItems.Count;
            leds_selected = null;
            if (nselect == 0) return;
            selected_led = int.Parse(LB_Leds.SelectedItem.ToString()) - 1;
            
            GB_Led.Enabled = true;

            if (nselect == 1) {
                
                me_x = true; me_y = true; me_sx = true; me_sy = true;
                GB_Led.Text = "LED[" + selected_led + "]";
                if (f_preview1 != null) f_preview1.focusPixel(selected_led);
            } else {
                leds_selected = new int[nselect];
                f_preview1.unfocus();
                me_x = true; me_y = true; me_sx = true; me_sy = true;

                GB_Led.Text = "LED[";
                for (int i = 0; i < nselect; i++) {
                    int i_selected = int.Parse(LB_Leds.SelectedItems[i].ToString()) - 1;
                    leds_selected[i] = i_selected;
                    if (f_preview1 != null) f_preview1.focus(i_selected);
                    GB_Led.Text += i_selected.ToString() + ";";

                    if (i > 0) {
                        if (leds[i_selected, 0] != leds[i_selected - 1, 0]) me_x = false;
                        if (leds[i_selected, 1] != leds[i_selected - 1, 1]) me_y = false;
                        if (leds[i_selected, 2] != leds[i_selected - 1, 2]) me_sx = false;
                        if (leds[i_selected, 3] != leds[i_selected - 1, 3]) me_sy = false;
                    }
                }
                GB_Led.Text += "]";
            }

            if (me_x) {
                label12.Text = "Start X:";
                TB_led_startX.Text = leds[selected_led, 0].ToString();
                TB_led_startX.ForeColor = Color.FromKnownColor(KnownColor.Black);
            } else {
                label12.Text = "Start X':";
                TB_led_startX.Text = "0";
                TB_led_startX.ForeColor = Color.FromKnownColor(KnownColor.Red);
            }

            if (me_y) {
                label11.Text = "Y:";
                TB_led_startY.Text = leds[selected_led, 1].ToString();
                TB_led_startY.ForeColor = Color.FromKnownColor(KnownColor.Black);
            } else {
                label11.Text = "Y':";
                TB_led_startY.Text = "0";
                TB_led_startY.ForeColor = Color.FromKnownColor(KnownColor.Red);
            }

            if (me_sx) {
                label10.Text = "Size X:";
                TB_led_sizeX.Text = leds[selected_led, 2].ToString();
                TB_led_sizeX.ForeColor = Color.FromKnownColor(KnownColor.Black);
            } else {
                label10.Text = "Size X':";
                TB_led_sizeX.Text = "0";
                TB_led_sizeX.ForeColor = Color.FromKnownColor(KnownColor.Red);
            }

            if (me_sy) {
                label9.Text = "Y:";
                TB_led_sizeY.Text = leds[selected_led, 3].ToString();
                TB_led_sizeY.ForeColor = Color.FromKnownColor(KnownColor.Black);
            } else {
                label9.Text = "Y':";
                TB_led_sizeY.Text = "0";
                TB_led_sizeY.ForeColor = Color.FromKnownColor(KnownColor.Red);
            }

            
        }

        private void led_change() {
            if (TB_led_startX.Text != "") {
                if (leds_selected == null)
                    leds[selected_led, 0] = int.Parse(TB_led_startX.Text);
                else
                    for (int i = 0; i < leds_selected.Count(); i++)
                        if (me_x) leds[leds_selected[i], 0] = int.Parse(TB_led_startX.Text); else leds[leds_selected[i], 0] += int.Parse(TB_led_startX.Text);
            }

            if (TB_led_startY.Text != "") {
                if (leds_selected == null)
                    leds[selected_led, 1] = int.Parse(TB_led_startY.Text);
                else
                    for (int i = 0; i < leds_selected.Count(); i++)
                        if (me_y) leds[leds_selected[i], 1] = int.Parse(TB_led_startY.Text); else leds[leds_selected[i], 1] += int.Parse(TB_led_startY.Text);
            }

            if (TB_led_sizeX.Text != "") {
                if (leds_selected == null)
                    leds[selected_led, 2] = int.Parse(TB_led_sizeX.Text);
                else
                    for (int i = 0; i < leds_selected.Count(); i++)
                        if (me_sx) leds[leds_selected[i], 2] = int.Parse(TB_led_sizeX.Text); else leds[leds_selected[i], 2] += int.Parse(TB_led_sizeX.Text);
            }

            if (TB_led_sizeY.Text != "") {
                if (leds_selected == null)
                    leds[selected_led, 3] = int.Parse(TB_led_sizeY.Text);
                else
                    for (int i = 0; i < leds_selected.Count(); i++)
                        if (me_sy) leds[leds_selected[i], 3] = int.Parse(TB_led_sizeY.Text); else leds[leds_selected[i], 3] += int.Parse(TB_led_sizeY.Text);
            }

            if (!me_x) TB_led_startX.Text = 0.ToString();
            if (!me_y) TB_led_startY.Text = 0.ToString();
            if (!me_sx) TB_led_sizeX.Text = 0.ToString();
            if (!me_sy) TB_led_sizeY.Text = 0.ToString();
        }

        private void TB_led_startX_TextChanged(object sender, EventArgs e) {
 
        }

        private void TB_led_startY_TextChanged(object sender, EventArgs e) {

        }

        private void TB_led_sizeX_TextChanged(object sender, EventArgs e) {

        }

        private void TB_led_sizeY_TextChanged(object sender, EventArgs e) {

        }

        private void TB_StartX_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-' && !TB_StartX.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_StartY_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-' && !TB_StartY.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_SizeX_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_SizeY_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_led_startX_KeyPress(object sender, KeyPressEventArgs e) {
            if ( e.KeyChar == '-' && !TB_led_startX.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_led_startY_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-' && !TB_led_startX.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_led_sizeX_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-' && !TB_led_startX.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_led_sizeY_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '-' && !TB_led_startX.Text.Contains('-')) return;
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BT_Preview_Click(object sender, EventArgs e) {
            led_change();
            preview();
        }

        private void button1_Click(object sender, EventArgs e) {

            TB_Config.Text = TB_Head.Text;
            string led_config = "";
            for(int i = 0; i < i_led; i++) {
                led_config = "[LED_" + (i+1).ToString() + "]" + Environment.NewLine;
                led_config += "IsEnabled=true" + Environment.NewLine;
                led_config += "Position=@Point("+ leds[i,0].ToString() + " " + leds[i, 1].ToString() + ")" + Environment.NewLine;
                led_config += "Size=@Size(" + leds[i, 2].ToString() + " " + leds[i, 3].ToString() + ")" + Environment.NewLine;
                led_config += "CoefRed=1" + Environment.NewLine + "CoefGreen=1" + Environment.NewLine + "CoefBlue=1" + Environment.NewLine + Environment.NewLine;
                TB_Config.Text += led_config;
            }
        }

        private void BT_X_L_Click(object sender, EventArgs e) {
            TB_StartX.Text = (int.Parse(TB_StartX.Text) - int.Parse(TB_SizeX.Text)).ToString();
        }

        private void BT_X_P_Click(object sender, EventArgs e) {
            TB_StartX.Text = (int.Parse(TB_StartX.Text) + int.Parse(TB_SizeX.Text)).ToString();
        }

        private void BT_Y_L_Click(object sender, EventArgs e) {
            TB_StartY.Text = (int.Parse(TB_StartY.Text) - int.Parse(TB_SizeY.Text)).ToString();
        }

        private void BT_Y_P_Click(object sender, EventArgs e) {
            TB_StartY.Text = (int.Parse(TB_StartY.Text) + int.Parse(TB_SizeY.Text)).ToString();
        }

        private void BT_DeleteSel_Click(object sender, EventArgs e) {
            int ndel = LB_Leds.SelectedItems.Count;
            i_led = i_led - ndel;
            LB_Leds.Items.Clear();

            for(int i = 0; i < i_led; i++) {
                LB_Leds.Items.Add(i+1);
            }

            f_preview1.Close();
            f_preview1 = new F_Preview();
            preview();
        }

        private void process_text() {
            if (TB_Config.Text.Contains("General")) {
                TB_Head.Text = TB_Config.Text.Substring(0, TB_Config.Text.IndexOf("[LED"));
            }

            LB_Leds.Items.Clear();
            i_led = int.Parse(TB_totaleds.Text);

            int cursor = 0, cursor_aux = 0;

            for(int i = 0; i <i_led; i++) {
                cursor = TB_Config.Text.IndexOf("[LED_" + (i+1).ToString() + "]");

                if (cursor == -1) {
                    MessageBox.Show("ERROR: No valid file, one of leds couldn't be processed [" + (i+1).ToString() + "]");
                    LB_Leds.Items.Clear();
                    i_led = 0;
                    return;
                }

                cursor = TB_Config.Text.IndexOf("Point", cursor) + 6;
                cursor_aux = TB_Config.Text.IndexOf(" ", cursor);
                leds[i, 0] = int.Parse(TB_Config.Text.Substring(cursor, cursor_aux - cursor));
                leds[i, 1] = int.Parse(TB_Config.Text.Substring(cursor_aux+1, TB_Config.Text.IndexOf(")", cursor) - cursor_aux - 1));

                cursor = TB_Config.Text.IndexOf("@Size", cursor) + 6;
                cursor_aux = TB_Config.Text.IndexOf(" ", cursor);
                leds[i, 2] = int.Parse(TB_Config.Text.Substring(cursor, cursor_aux - cursor));
                leds[i, 3] = int.Parse(TB_Config.Text.Substring(cursor_aux + 1, TB_Config.Text.IndexOf(")", cursor) - cursor_aux - 1));

                LB_Leds.Items.Add((i + 1).ToString());
            }
        }

        private void BT_Load_Click(object sender, EventArgs e) {
            if(int.Parse(TB_totaleds.Text) == 0) TB_totaleds.Text = Microsoft.VisualBasic.Interaction.InputBox("Set number of all leds to load: ", "Number Leds");

            openFileDialog1.InitialDirectory = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Prismatik\\Profiles";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                TB_Config.Text = (sr.ReadToEnd());
                sr.Close();
            }

            process_text();
            preview();
        }

        private void RB_Ws_CheckedChanged(object sender, EventArgs e) {
            if (RB_Ws.Checked) this.Width = 350;
        }

        private void RB_Wm_CheckedChanged(object sender, EventArgs e) {
            if (RB_Wm.Checked) this.Width = 700;
        }

        private void RB_Wl_CheckedChanged(object sender, EventArgs e) {
            if (RB_Wl.Checked) this.Width = 1050;
        }

        private void TB_ResX_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BT_Save_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "PLSC-" + i_led.ToString() + ".ini";
            save.Filter = "Config file | *.ini";

            if (save.ShowDialog() == DialogResult.OK) {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(save.OpenFile());
                writer.WriteLine(TB_Config.Text);
                writer.Dispose();
                writer.Close();
            }

            MessageBox.Show("Saved!");
        }

        private void calcule_position() {
            if (RB_Left.Checked) {
                TB_StartX.Text = (leds[i_led-1, 0] - int.Parse(TB_SizeX.Text)).ToString();
                TB_StartY.Text = leds[i_led-1, 1].ToString();
            } else if (RB_Right.Checked) {
                TB_StartX.Text = (leds[i_led-1, 0] + int.Parse(TB_SizeX.Text)).ToString();
                TB_StartY.Text = leds[i_led-1, 1].ToString();
            } else if (RB_Up.Checked) {
                TB_StartX.Text = leds[i_led-1, 0].ToString();
                TB_StartY.Text = (leds[i_led-1, 1] - int.Parse(TB_SizeY.Text)).ToString();
            } else if (RB_Down.Checked) {
                TB_StartX.Text = leds[i_led-1, 0].ToString();
                TB_StartY.Text = (leds[i_led-1, 1] + int.Parse(TB_SizeY.Text)).ToString();
            }
        }

        private void BT_Auto_Click(object sender, EventArgs e) {
            calcule_position();
        }

        private void TB_ResX_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_ResY_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_NLeds_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TB_SizeY_TextChanged(object sender, EventArgs e) {
        }

        private void TB_StartX_TextChanged(object sender, EventArgs e) {

        }

        private void F_Main_Load(object sender, EventArgs e) {
            this.Width = 700;
        }

        private void BT_Delete_Click(object sender, EventArgs e) {
            GB_Led.Enabled = false;
            i_led = 0;
            LB_Leds.Items.Clear();
            f_preview1.Close();
            f_preview1 = new F_Preview();
        }
    }
}
