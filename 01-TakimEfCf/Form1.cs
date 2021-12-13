using _01_TakimEfCf.Context;
using _01_TakimEfCf.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_TakimEfCf
{
    public partial class Form1 : Form
    {
        FanManagementDbContext db = new FanManagementDbContext();
        public Form1()
        {
            InitializeComponent();
            GetTeams();
        }

        private void GetTeams()
        {
            cmbTeams.DataSource = db.Teams.ToList();

            var teamList = db.Teams.ToList();
            teamList.Insert(0, new Team()
            {
                TeamName = "No team",
                Students = db.Students.Where(k => k.TeamId == null).ToList()
            }); ;
            cmbTeamsFan.DataSource = teamList;

   
        }

        private void cmbTeamsFan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTeamsFan.SelectedItem == null)
            {
                lstStudents.DataSource = null;
                return;
            }
            Team team = (Team)cmbTeamsFan.SelectedItem;
            lstStudents.DataSource = team.Students?.ToList();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = txtTeamName.Text.Trim();
            if (teamName == null) return;
            db.Teams.Add(new Team() { TeamName = teamName });
            db.SaveChanges();
            GetTeams();
            txtTeamName.Clear();
            txtTeamName.Focus();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            Team team = (Team)cmbTeams.SelectedItem;
            if (studentName == "" || !chkFanStatus.Checked && team == null) return;

            Student student = new Student()
            {
                Name = studentName,
                Team = chkFanStatus.Checked ? null : team
            };
            db.Students.Add(student);
            db.SaveChanges();
            GetTeams();
            txtStudentName.Clear();
        }

        private void chkFanStatus_CheckedChanged(object sender, EventArgs e)
        {
            cmbTeams.Enabled = !chkFanStatus.Checked;
        }

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            Team team = (Team)cmbTeamsFan.SelectedItem;
            if (team == null || team.Id == 0) return;
            db.Teams.Remove(team);
            db.SaveChanges(); //TODO:
            GetTeams();
        }
    }
}
