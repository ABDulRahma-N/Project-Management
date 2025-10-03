using ProjectManagmentDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementBusinessLayer
{
    public class ClsTasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime ActualEndDate { get; set; }
        public string Status { get; set; }
        public int ProjectID { get; set; }
        public int AssignedTo {  get; set; }

        public ClsTasks ()
        {
            Id = -1;
            Title = "";
            Description = "";
            StartDate = DateTime.MinValue;
            PlannedEndDate = DateTime.MinValue;
            ActualEndDate = DateTime.MinValue;
            Status = "";
            ProjectID = -1;
            AssignedTo = -1;
        }
        private ClsTasks (int id,string title,string description,DateTime startdate,DateTime plannedenddate,DateTime actualenddate,string status,int projectid,int assignedto)
        {
            Id = id;
            Title = title;
            Description = description;
            StartDate = startdate;
            PlannedEndDate = plannedenddate;
            ActualEndDate = actualenddate;
            Status = status;
            ProjectID = projectid;
            AssignedTo = assignedto;
        }
        public static DataTable GetAllTask()
        {
            return ClsTaskData.GetAllTasks();
        }
        public static DataView GetAllTaskByProjectId(int id)
        {
            DataView Dt=ClsTaskData.GetAllTasks().DefaultView;

            Dt.RowFilter = $"ProjectID={id}";
            return Dt;
        }
        public static ClsTasks Find(int id)
        {
            string Title = "", Description="",Status="";
            int AssignedTo=-1,ProjectID=-1;
            DateTime StartDate = DateTime.MinValue, PlannedEndDate = DateTime.MinValue, ActualEndDate = DateTime.MinValue;
            if(ClsTaskData.GetTaskById(id,ref Title,ref Description,ref StartDate,ref PlannedEndDate,ref ActualEndDate,ref Status,ref ProjectID,ref AssignedTo))
            {
                return new ClsTasks(id, Title, Description, StartDate, PlannedEndDate, ActualEndDate, Status, ProjectID, AssignedTo);
            }
            return null;
        }
        public bool AddNewTask()
        {
            if (Id == -1)
            {
                int NewID = ClsTaskData.AddTask(Title, Description, StartDate, PlannedEndDate, ActualEndDate, ProjectID, AssignedTo);
              
                    this.Id = NewID;
                    return true;
                
                
            }
            return false;
        }
        public bool UpdateTask()
        {
            if (Id != -1)
            {
                return ClsTaskData.UpdateTask(Id, Title, Description, StartDate, PlannedEndDate, ActualEndDate, Status, ProjectID, AssignedTo);
            }
            return false;
        }
        static public bool DeleteTask(int id)
        {
            return ClsTaskData.DeleteTask(id);
        }
    }
}
