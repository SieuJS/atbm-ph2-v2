namespace WinFormsProject
{
    public class User
    {
        public string UserName { get; set; }
        public List<Role> Roles { get; set; }
        public List<Privelege> Priveleges { get; set; }
        public User()
        {
            //Set default values for properties
            UserName = "Admin";
            Roles = new List<Role>();
            Priveleges = new List<Privelege>();
        }
    }
    public class Role
    {
        public string RoleName { get; set; }
        public List<Privelege> Priveleges { get; set; }

        public Role()
        {
            //Set default values for properties
            RoleName = "Admin";
            Priveleges = new List<Privelege>();
        }
    }
    public class Privelege
    {
        public string TableName { get; set; }
        public string PrivelegeName { get; set; }
        public List<string> ColumnNames { get; set; }
        public bool WithGrantOption { get; set; }
        public Privelege()
        {
            //Set default values for properties
            TableName = "Admin";
            ColumnNames = new List<string>();
            PrivelegeName = "SELECT";
            WithGrantOption = true;
        }
    }
    public static class PrivilegeHelper
    {
        public static string GetPrivilegesString(List<Privelege> privileges)
        {
            string privilegesStr = "";
            foreach (Privelege privilege in privileges)
            {
                if (privileges.IndexOf(privilege) > 2)
                {
                    break;
                }
                privilegesStr += privilege.PrivelegeName;
                if (privilege.ColumnNames.Count > 0)
                {
                    privilegesStr += " (";
                    foreach (string columnName in privilege.ColumnNames)
                    {
                        privilegesStr += columnName + ", ";
                    }
                    privilegesStr = privilegesStr.Substring(0, privilegesStr.Length - 2);
                    privilegesStr += ")";
                }
                privilegesStr +=  " On " + privilege.TableName + ", ";
            }
            if (privileges.Count > 3)
            {
                privilegesStr += "...";
            }
            return privilegesStr;
        }

        public static string GetRolesString(List<Role> roles)
        {
            string rolesStr = "";
            foreach (Role role in roles)
            {
                rolesStr += role.RoleName + ", ";
            }
            return rolesStr;
        }
        
    }
}
    

