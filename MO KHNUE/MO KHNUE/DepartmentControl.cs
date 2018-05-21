using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MO_KHNUE.Entities;

namespace MO_KHNUE
{
    public partial class DepartmentControl : UserControl
    {
        private Department department = null;
        public event BlockValueChangedHandler<Department> DepartmentChanged;
        public DepartmentControl()
        {
            CustomInit();
        }
        public DepartmentControl(Department department)
        {
            CustomInit();
            InitDepartment(department);
        }

        void UpdateMembersLists()
        {
            try
            {
                var context = Database.DBContext.UpdateDbContext();
                var membAll = context.Members;


                department = context.Departments.Find(dep => dep?.ID == department?.ID);


                if (department != null)
                {
                    departmentHeadBlock.Value = department.Head;
                    memberBlocksListCurrent.SetValues(department.Members);
                    memberBlocksListAll.SetValues(membAll.Except(department.Members).Except(new[] { department.Head }).ToList());
                }
                else
                {
                    departmentHeadBlock.Value = null;
                    memberBlocksListCurrent.ClearValues();
                    memberBlocksListAll.ClearValues();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить список доступных участников!");
            }
        }

        void CustomInit()
        {
            InitializeComponent();
            memberBlocksListCurrent.BlockDoubleClicked += (s) =>
            {
                if (s != null)
                    RemoveMember(s);
            };
            memberBlocksListAll.MenuDetailsButtonClick += (s) =>
            {
                if (s != null)
                    MainForm.instance.ShowContent(new MemberInfoControl(memberBlocksListAll.GetSelectedValue()));
            };
            departmentHeadBlock.CustomMouseDoubleClick += () =>
            {
                MainForm.instance.ShowContent(new MemberInfoControl(departmentHeadBlock.Value));
            };
            BackColor = Theme.DefaultBackgorundColor;
            memberBlocksListCurrent.AddButton.Visible = false;
            memberBlocksListCurrent.EditButton.Visible = false;
            memberBlocksListCurrent.RemoveButton.Visible = false;

            memberBlocksListAll.RemoveButton.Visible = false;
            memberBlocksListAll.EditButton.Visible = false;
            //memberBlocksListAll.DetailsButton.Visible = false;
            memberBlocksListCurrent.CreateButton("", selected =>
            {
                if (selected != null)
                    SetLeader(selected);
            });
            memberBlocksListAll.CreateButton("", selected =>
            {
                if (selected != null)
                    SetLeader(selected);
            });

            memberBlocksListCurrent.DetailsButton.Click += (s, e) =>
            {
                MainForm.instance.ShowContent(new MemberInfoControl(memberBlocksListCurrent.GetSelectedValue()));
            };

        }

        public void InitDepartment(Department department)
        {
            this.department = department;
            UpdateMembersLists();
        }

        private void AddMember(Member currentValue)
        {
            try
            {
                var context = Database.DBContext.UpdateDbContext();
                var membAll = context.Members;

                department = context.Departments.Find(dep => dep?.ID == department?.ID);
                currentValue = context.Members.Find(mem => mem?.ID == currentValue?.ID);

                if (currentValue == null || department == null)
                {
                    MessageBox.Show("Ошибка! Данных болше не существует!");
                    return;
                }

                department.Members.Add(currentValue);
                context.SaveChanges();
                UpdateMembersLists();

            }
            catch
            {
                MessageBox.Show("Не удалось добавить участника: ошибка связи с базой данных!");
            }
        }

        private void RemoveMember(Member currentValue)
        {
            try
            {
                var context = Database.DBContext.UpdateDbContext();
                var membAll = context.Members;

                department = context.Departments.Find(dep => dep?.ID == department?.ID);
                currentValue = context.Members.Find(mem => mem?.ID == currentValue?.ID);

                if (currentValue == null || department == null)
                {
                    MessageBox.Show("Ошибка! Данных болше не существует!");
                    return;
                }

                department.Members.Remove(currentValue);
                context.SaveChanges();
                UpdateMembersLists();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить участника: ошибка связи с базой данных!");
            }
        }

        private void SetLeader(Member currentValue)
        {
            try
            {
                var context = Database.DBContext.UpdateDbContext();
                var membAll = context.Members;

                department = context.Departments.Find(dep => dep?.ID == department?.ID);
                currentValue = context.Members.Find(mem => mem?.ID == currentValue?.ID);

                if (currentValue == null || department == null)
                {
                    MessageBox.Show("Ошибка! Данных болше не существует!");
                    return;
                }

                if (department.Head != null)
                    department.Members.Add(department.Head);

                department.Head = context.Members.Find(mem => mem?.ID == currentValue?.ID);

                department.Members.Remove(currentValue);
                department.Members = department.Members.Except(new[] { department.Head }).ToList();
                context.SaveChanges();
                UpdateMembersLists();
            }
            catch
            {
                MessageBox.Show("Не удалось добавить участника: ошибка связи с базой данных!");
            }
        }
    }
}
