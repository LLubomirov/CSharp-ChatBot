﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Controllers
{
    public class KPIRequestDataWithoutPart
    {

        #region DataMembers
        private string workOrder;
        private string kpiType; 
        #endregion

        public string WorkOrder
        {
            get => workOrder;
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                else
                {
                    foreach (char symbol in value)
                    {
                        if(symbol < '0' || symbol > '9')
                        {
                            throw new ArgumentException();
                        }
                    }

                    workOrder = value;
                }
            }
        }

        public string KpiType
        {
            get => kpiType;
            set
            {

            }
        }

        public string 
    }
}
