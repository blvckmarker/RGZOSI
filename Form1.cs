using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard
{
    public partial class Emultor : Form
    {
      uint fileSize = 0, bufferSize = 0, bufferNums = 0;
      //List<bool> VzyArray = new List<bool>();
      //List<bool> BufferArray = new List<bool>();


      public Emultor()
      {
         InitializeComponent();
      }
    
//
//    Вычисляет количество полосок в ВЗУ
//
      private uint RisNum() =>
         (fileSize % bufferSize) == 0 ? (uint)(fileSize / bufferSize)
         : (uint)(fileSize / bufferSize) + 1;

      /*// ######################################################################
       * Эту херню лучше переделать... 
       * Если Кобылянский это увидет, то возможны проблемы,
       * ибо я никогда в жизни более упоротого костыля никогда не писал.
       * Хотя он работает безотказно
      */// ######################################################################

      private void ChangeVzuVisible(uint n)
      { 
         if (n >= 1) Ris1.Visible = true; else Ris1.Visible = false;
         if (n >= 2) Ris2.Visible = true; else Ris2.Visible = false;
         if (n >= 3) Ris3.Visible = true; else Ris3.Visible = false;
         if (n >= 4) Ris4.Visible = true; else Ris4.Visible = false;
         if (n >= 5) Ris5.Visible = true; else Ris5.Visible = false;
         if (n >= 6) Ris6.Visible = true; else Ris6.Visible = false;
         if (n >= 7) Ris7.Visible = true; else Ris7.Visible = false;
         if (n >= 8) Ris8.Visible = true; else Ris8.Visible = false;
         if (n >= 9) Ris9.Visible = true; else Ris9.Visible = false;
         if (n >= 10) Ris10.Visible = true; else Ris10.Visible = false;
         if (n >= 11) Ris11.Visible = true; else Ris11.Visible = false;
         if (n >= 12) Ris12.Visible = true; else Ris12.Visible = false;
         if (n >= 13) Ris13.Visible = true; else Ris13.Visible = false;
         if (n >= 14) Ris14.Visible = true; else Ris14.Visible = false;
         if (n >= 15)
         {
            MessageBox.Show(
               "Невозможно отобразить\n Измените входные параметры",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            textBoxBufferSize.Text = "";
            textBoxFileSize.Text = "";
            ChangeVzuVisible(0);
         }
      }

      /*// ######################################################################
       * Эту херню лучше переделать... 
       * Если Кобылянский это увидет, то возможны проблемы,
       * ибо я никогда в жизни более упоротого костыля никогда не писал.
       * Хотя он работает безотказно
      */// ######################################################################
      private void ChangeBufferVisible(uint n)
      {
         if (n >= 1) Ris1_1.Visible = true; else Ris1_1.Visible = false;
         if (n >= 2) Ris1_2.Visible = true; else Ris1_2.Visible = false;
         if (n >= 3) Ris1_3.Visible = true; else Ris1_3.Visible = false;
         if (n >= 4) Ris1_4.Visible = true; else Ris1_4.Visible = false;
         if (n >= 5) Ris1_5.Visible = true; else Ris1_5.Visible = false;
         if (n >= 6) Ris1_6.Visible = true; else Ris1_6.Visible = false;
         if (n >= 7) Ris1_7.Visible = true; else Ris1_7.Visible = false;
         if (n >= 8) Ris1_8.Visible = true; else Ris1_8.Visible = false;
         if (n >= 9) Ris1_9.Visible = true; else Ris1_9.Visible = false;
         if (n >= 10) Ris1_10.Visible = true; else Ris1_10.Visible = false;
         if (n >= 11) Ris1_11.Visible = true; else Ris1_11.Visible = false;
         if (n >= 12) Ris1_12.Visible = true; else Ris1_12.Visible = false;
         if (n >= 13) Ris1_13.Visible = true; else Ris1_13.Visible = false;
         if (n >= 14) Ris1_14.Visible = true; else Ris1_14.Visible = false;
         if (n >= 15)
         {
            MessageBox.Show(
               "Невозможно отобразить\n Измените входные параметры",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            textBoxBufferNums.Text = "";
            ChangeBufferVisible(0);
         }
      }


      /*
       * Метод вводит необходимые значения в 3-ее поле 
       * проверяет тип данных и передаёт значение в 
       * функцию (костыль) который нарисует полоски в 
       * буфере
      */
		private void textBoxBufferNums_TextChanged(object sender, EventArgs e)
		{
         if (!String.IsNullOrEmpty(textBoxBufferNums.Text))
         {
            try
            {
               bufferNums = Convert.ToUInt32(textBoxBufferNums.Text);
            }
            catch (FormatException)
            {
               MessageBox.Show(
               "Неправильный формат ввода",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
               ChangeBufferVisible(bufferNums);
               textBoxBufferNums.Text = Convert.ToString(bufferNums);
            }
         }
         else
            bufferNums = 0;
         ChangeBufferVisible(bufferNums);
      }


      /*
       * Метод вводит необходимые значения во 2-ое поле 
       * проверяет тип данных и передаёт значение в 
       * функцию (костыль) который нарисует полоски в 
       * ВЗУ
      */

      private void textBoxBufferSize_TextChanged(object sender, EventArgs e)
		{
         if (!String.IsNullOrEmpty(textBoxBufferSize.Text))
         {
            try
            {
               bufferSize = Convert.ToUInt32(textBoxBufferSize.Text);
            }
            catch (FormatException)
            {
               MessageBox.Show(
               "Неправильный формат ввода",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            if (bufferSize != 0)
            {
               textBoxBufferSize.ForeColor = Color.Black;
               ChangeVzuVisible(RisNum());
            }
            else
            {
					System.Media.SystemSounds.Beep.Play();
               textBoxBufferSize.ForeColor = Color.Red;
               ChangeVzuVisible(0);
            }
         }
      }

      /*
       * Метод вводит необходимые значения в 1-ое поле и 
       * проверяет тип данных
      */

      private void textBoxFileSize_TextChanged(object sender, EventArgs e)
		{
         if (!String.IsNullOrEmpty(textBoxFileSize.Text))
         {
            try
            {
               fileSize = Convert.ToUInt32(textBoxFileSize.Text);
            }
            catch (FormatException)
            {
               MessageBox.Show(
               "Неправильный формат ввода",
               "Ошибка",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
               textBoxFileSize.Text = Convert.ToString(fileSize);
            }

            if (bufferSize != 0)
               ChangeVzuVisible(RisNum());
            else
               ChangeVzuVisible(0);
         }
      }

		private void Ris1_6_Paint(object sender, PaintEventArgs e)
		{

		}

		/*
       * На потом
      */


		private void VzuToBuffer_Click(object sender, EventArgs e)
      {
         MessageBox.Show(
            "Эта команда будет переводить\n" +
            "память из ВЗУ в буфер");
      }

      /*
       * На потом
      */

      private void BufferToProgr_Click(object sender, EventArgs e)
      {
         if (panelka2.Location.X == Ris1_1.Location.X)
            panelka2.Location = new Point(78, panelka2.Location.Y);
         else
            panelka2.Location = new Point(panelka2.Location.X + 37, panelka2.Location.Y);
      }
   }
}
