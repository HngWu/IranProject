using IranProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IranProject
{
    public partial class CreateRequest : Form
    {

        static List<Saloon> saloonList;
        static List<Category> categoryList;
        static List<WorkshopTime> workshopTimeList;


        public CreateRequest()
        {
            InitializeComponent();
        }

        private void CreateRequest_Load(object sender, EventArgs e)
        {
            using(var context = new IranProjectContext())
            {
                saloonList = context.Saloon.ToList();
                categoryList = context.Category.ToList();
                workshopTimeList = context.WorkshopTime.ToList();

                foreach (var saloon in saloonList)
                {
                    saloonComboBox.Items.Add(saloon.SaloonName);
                }
                foreach (var category in categoryList)
                {
                    CategoryComboBox.Items.Add(category.CategoryName);
                }
                foreach (var workshopTime in workshopTimeList)
                {
                    workshoptimeComboBox.Items.Add(workshopTime.Description);
                }

            }
        }

        private void submitRequestbutton_Click(object sender, EventArgs e)
        {
            var userId = CommonAccess.user.UserId;
            var saloonId = saloonList.Where(x => x.SaloonName == saloonComboBox.Text).FirstOrDefault().SaloonId;
            var categoryId = categoryList.Where(x=>x.CategoryName == CategoryComboBox.Text).FirstOrDefault().CategoryId;
            var workshopTimeId = workshopTimeList.Where(x => x.Description == workshoptimeComboBox.Text).FirstOrDefault().WorkshopTimeId;
            var Date = workshopDateTimePicker.Value.Date;
            var status = "Pending";

            var request = new WorkshopRequest()
            {
                UserId = userId,
                SaloonId = saloonId,
                CategoryId = categoryId,
                WorkshopTimeId = workshopTimeId,
                Date = Date,
                Status = status
            };
            using (var context = new IranProjectContext())
            {
                context.Add(request);
                context.SaveChanges();
            }
            ExhibitorRequestPanel exhibitorRequestPanel = CommonAccess.exhibitorRequestPanel;
            exhibitorRequestPanel.PopulateExhibitorRequestGridView();
            this.Hide();

        }
    }
}
