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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {

        }

        public void ClearText() { 
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        public void LoadMemberList() {
            var members = memberRepository.GetList();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Load member List");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK) {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private Member GetMemberObject() {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                var member = GetMemberObject();
                memberRepository.DeleteMember(member.MemberID);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }
        public void SearchById(int id)
        {
            var Mymember = memberRepository.GetMemberByID(id);
            IEnumerable<Member> members = new List<Member>() { Mymember };
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member List");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtSearch.Text);
            SearchById(ID);
        }

        
        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}
