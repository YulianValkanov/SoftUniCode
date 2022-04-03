using System;
using System.Collections.Generic;
using System.Text;

namespace TeisterMask.Common
{
    public static class GlobalConstants
    {

        //Employee
        public const int EMPLOYEE_USERNAME_MIN = 3;
        public const int EMPLOYEE_USERNAME_MAX = 40;
        public const string EMPLOYEE_USERNAME_REGEX = @"^[A-Za-z0-9]+$";
        public const int EMPLOYEE_PHONE_MAX = 12;
        public const string EMPLOYEE_PHONE_REGEX= @"^\d{3}-\d{3}-\d{4}$";

        //Projects
        public const int PROJECT_NAME_MAX = 40;
        public const int PROJECT_NAME_MIN = 2;


        //Tasks
        public const int TASK_NAME_MAX = 40;
        public const int TASK_NAME_MIN = 2;
        public const int EXECUTION_TYPE_MIN = 0;
        public const int EXECUTION_TYPE_MAX = 3;
        public const int LABLE_TYPE_MIN = 0;
        public const int LABLE_TYPE_MAX = 4;
    }
}
