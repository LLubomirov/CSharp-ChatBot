﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Controllers
{
    public class KPIRequestData
    {
        #region DataMembers
        // work order ID
        private string workOrder;
        // kpi type
        private string kpiType;
        // part number
        private string part;
        #endregion

        #region Property
        public string WorkOrder
        {
            get => workOrder;
            
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    foreach(char symbol in value)
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
            get
            {
                return kpiType;
            }
            set
            {

            }
        }
        #endregion
    }
}
