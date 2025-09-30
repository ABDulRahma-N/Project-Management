using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagmentDataLayer;

namespace ProjectManagementBusinessLayer
{
    public class ClsProject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime PlannedEndDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public string Status { get; set; }

        public ClsProject()
        {
            ID = -1;
            Name = "";
            Description = "";
            StartDate = DateTime.MinValue;
            PlannedEndDate = DateTime.MinValue;
            ActualEndDate = DateTime.MinValue;
            Status = "";
        }
        private ClsProject(int id, string name, string description, DateTime startDate, DateTime plannedEndDate, DateTime? actualEndDate, string status)
        {
            ID = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            PlannedEndDate = plannedEndDate;
            ActualEndDate = actualEndDate;
            Status = status;
        }
        static public ClsProject Find(int id)
        {
            
            string name = "",status="", description="";
            DateTime plannedEndDate=DateTime.MinValue, startDate=DateTime.MinValue, actualEndDate=DateTime.MinValue;
            if (clsProjectData.Find(id,ref name,ref description,ref startDate,ref plannedEndDate,ref actualEndDate,ref status))
            {
                return new ClsProject(id, name, description, startDate, plannedEndDate, actualEndDate, status);
            }
            else
            {
                return null;
            }
        }
        public int AddProject()
        {
           if(this.ID!=-1)
                return -1;
           this.ID = clsProjectData.AddProject(this.Name, this.Description, this.StartDate, this.PlannedEndDate);
            return this.ID;
        }
        public bool UpdateProject()
        {
            if (this.ID==-1)
            return false;
            return clsProjectData.UpdateProject(this.ID, this.Name, this.Description, this.StartDate, this.PlannedEndDate, this.ActualEndDate.Value, this.Status);


        }

        static public bool DeleteById(int Id)
        {
            return clsProjectData.DeleteProject(Id);
        }
        static public DataTable GetAllProject()
        {
            return clsProjectData.GetAllProjects();
        }
    }
}
