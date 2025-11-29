using QuanLyQuanCaPhe.DAO;
using QuanLyQuanCaPhe.DTO;

namespace QuanLyQuanCaPhe.BLL
{
    public class AccountBLL
    {
        public bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        public Account GetAccountByUserName(string userName)
        {
            return AccountDAO.Instance.GetAccountByUserName(userName);
        }

        public bool InsertAccount(string userName, string displayName, int type)
        {
            return AccountDAO.Instance.InsertAccount(userName, displayName, type);
        }

        public bool UpdateAccount(string userName, string displayName, int type)
        {
            return AccountDAO.Instance.UpdateAccount(userName, displayName, type);
        }

        public bool DeleteAccount(string userName)
        {
            return AccountDAO.Instance.DeleteAccount(userName);
        }

        public bool ResetPassword(string userName)
        {
            return AccountDAO.Instance.ResetPassword(userName);
        }

        public bool ChangePassword(string userName, string newPassword)
        {
            return AccountDAO.Instance.ChangePassword(userName, newPassword);
        }
    }
}
