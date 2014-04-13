using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MLN_ISDP_project
{
    class Task
    {
        //enum that backs all the indicator shit
        public enum TaskType { NONE, RECALL, WARRANTY }

        #region Properties

        //db properties
        private int TaskUniq { get; set; }
        public int TaskID { get; set; }
        public double TaskTime { get; set; }
        public List<string> TechList { get; set; }
        public string Description { get; set; }
        public string WorkOrderID { get; set; }
        public TaskType Type { get; set; }

        //util
        public bool Dirty { get; set; }

        #endregion

        public Task()
        {
            this.TaskUniq = -1;
            this.TaskTime = 1;
            TechList = new List<string>();
        }

        public Task(string woID)
        {
            this.WorkOrderID = woID;
            this.TaskTime = 1;
            this.TaskUniq = -1;
            TechList = new List<string>();
        }

        public Task(int id)
        {
            TaskUniq = id;
            TechList = new List<string>();
        }

        public Task(Task other)
        {
            TaskID = other.TaskID;
            TaskTime = other.TaskTime;
            TechList = other.TechList;
            Description = other.Description;
            WorkOrderID = other.WorkOrderID;
            Type = other.Type;
        }

        internal bool load(OracleDB in_db)
        {
            bool loadComplete = false;

            //doublechecks connection, whatever
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            //gets a datatable of every damn column in the parts table for this row, if it exists
            DataTable dt = in_db.readQuery("SELECT * FROM Task WHERE TaskUniq = " + this.TaskUniq);

            //if there is no row? we stay loaded-false and return negative. if not, then we set our properties like we didn't in the constructor
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    TaskID = int.Parse(dt.Rows[0]["TaskID"].ToString());
                    TaskTime = (double?)dt.Rows[0].Field<double?>("TaskTime") ?? 0;
                    Description = (string)dt.Rows[0]["Description"].ToString();
                    WorkOrderID = (string)dt.Rows[0]["WorkOrderID"].ToString();
                    string techTemp = (string)dt.Rows[0]["TechList"].ToString();

                    foreach(string tech in techTemp.Split(','))
                    {
                        TechList.Add(tech);
                    }

                    string typeTemp = (string)dt.Rows[0]["Type"];

                    typeTemp = typeTemp.ToUpper();

                    switch (typeTemp)
                    {
                        case "RECALL":
                            Type = TaskType.RECALL;
                            break;
                        case "WARRANTY":
                            Type = TaskType.WARRANTY;
                            break;
                        case "NONE":
                            Type = TaskType.NONE;
                            break;
                        default:
                            Type = TaskType.NONE;
                            break;
                    }

                    //we loaded, woo!
                    loadComplete = true;
                }
            }

            return loadComplete;
        }

        internal bool commit(OracleDB in_db)
        {
            bool writeComplete = false;
            if (!in_db.isConnected())
            {
                in_db.connect();
            }

            //need to make sure we're setting it dirty everywhere it gets changed first
            //if (this.Dirty)
            //{
                string techs = String.Join(",", this.TechList);
                if (this.TaskUniq != -1)
                {
                    string sanitizedDesc = this.Description.Replace("'", "''");

                    writeComplete = in_db.insertQuery("UPDATE Task "
                                    + "SET TaskID = " + this.TaskID + ","
                                    + "TaskTime = " + this.TaskTime + ","
                                    + "TechList = '" + String.Join(",", this.TechList) + "',"
                                    + "Description = '" + sanitizedDesc + "',"
                                    + "WorkOrderID = '" + this.WorkOrderID + "',"
                                    + "Type = '" + this.Type.ToString() + "' "
                                    + "WHERE TaskUniq = '" + this.TaskUniq + "'");
                }
                else
                {
                    writeComplete = in_db.insertQuery("INSERT INTO Task (TaskID, TaskTime, TechList, Description, WorkOrderID, Type) "
                                    + "VALUES (" + this.TaskID + ","
                                    + this.TaskTime + ","
                                    + "'" + String.Join(",", this.TechList) + "',"
                                    + "'" + this.Description + "',"
                                    + "'" + this.WorkOrderID + "',"
                                    + "'" + this.Type.ToString() + "')");
                }

                this.Dirty = false;

            //}
            return writeComplete;
        }
    }
}
