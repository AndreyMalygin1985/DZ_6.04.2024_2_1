using System.Xml.Linq;

namespace DZ_6._04._2024_2_1
{
    public partial class Form1 : Form
    {
        private string surnameText, nameText, surname2Text, sexText, birthDateText, familyStatusText, additionalInfoText;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                string userData = $"�������: {surnameText}\n" +
                                  $"���: {nameText}\n" +
                                  $"��������: {surname2Text}\n" +
                                  $"���: {sexText}\n" +
                                  $"���� ��������: {birthDateText}\n" +
                                  $"�������� ������: {familyStatusText}\n" +
                                  $"�������������� ����������: {additionalInfoText}";

                File.WriteAllText("user_data.txt", userData);
                MessageBox.Show("������ ������� ��������� � ���� user_data.txt.");
            }
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            surnameText = Surname.Text;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            nameText = Name.Text;
        }

        private void Surname2_TextChanged(object sender, EventArgs e)
        {
            surname2Text = Surname2.Text;
        }

        private void Sex_TextChanged(object sender, EventArgs e)
        {
            sexText = Sex.Text;
        }

        private void YearAndDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            birthDateText = YearAndDateOfBirth.Text;
        }

        private void FamilyStatus_TextChanged(object sender, EventArgs e)
        {
            familyStatusText = FamilyStatus.Text;
        }

        private void AdditionalInformation_TextChanged(object sender, EventArgs e)
        {
            additionalInfoText = AdditionalInformation.Text;
        }

        /*public Form1()
        {
            InitializeComponent();
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Surname2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sex_TextChanged(object sender, EventArgs e)
        {

        }

        private void YearAndDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void FamilyStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdditionalInformation_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
