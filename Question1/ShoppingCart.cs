using Question1.Properties;
using System;

namespace SimcorpInterview
{
    /// <summary>
    /// You are working with an intern who has just joined your team.
    /// They have little experience of coding, and have started writing a new software application
    /// 
    /// They have approached you for help. Suggest the most useful improvements to this class.
    /// </summary>
    public class ShoppingCart
    {
        public ShoppingCart()
        {
        }

        public void ShoppingCartItemAddProcessing(ShopItem item)
        {
            ShopItemRepository r = new ShopItemRepository(Resources.DefaultConnectionString);
            try
            {
                r.Add(item);
                EmailSender.Instance.SendEmail("Thankyou for your purchase");
                r.Save();
            }
            catch (Exception e)
            {
                if (!(e is RepositoryException))
                {
                    throw;
                }
                else
                {
                    new ConsoleLogger().WriteLog("Failed");
                }
            }
        }
    }

    #region Dummy classes

    public class RepositoryException : Exception { }
    public class ShopItem { }
    public class ConsoleLogger
    {
        public void WriteLog(string message) { }
    }
    #endregion

}
