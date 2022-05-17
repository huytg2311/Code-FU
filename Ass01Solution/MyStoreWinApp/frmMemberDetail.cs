using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfo { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true) {

                txtMemberID.Text = MemberInfo.MemberID.ToString();
                txtMemberName.Text = MemberInfo.MemberName;
                txtEmail.Text = MemberInfo.Email;
                txtPassword.Text = MemberInfo.Password;
                txtCity.Text = MemberInfo.City;
                txtCountry.Text = MemberInfo.Country;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
