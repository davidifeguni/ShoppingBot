namespace LuisBot.Dialogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web;
    using Microsoft.Bot.Builder.Dialogs;
    using Microsoft.Bot.Builder.FormFlow;
    using Microsoft.Bot.Builder.Luis;
    using Microsoft.Bot.Builder.Luis.Models;
    using Microsoft.Bot.Connector;
    using Microsoft.Office.Interop.Excel;
    using _Excel = Microsoft.Office.Interop.Excel;

    [LuisModel("7593ec5a-3119-4e83-b9f5-2766444735e8", "732d85b83c644b7e8bff565529a19b84")]
    [Serializable]
    public class RootLuisDialog : LuisDialog<object>
    {
        private const string EntityItem = "Item";

        private const string EntityAddToCart = "AddToCart";

        
        [LuisIntent("None")]
        public async Task NoneIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"I'm sorry, I did not understand '{result.Query}'."); //
            context.Wait(MessageReceived);
        }

        [LuisIntent("AddToCart")]
        public async Task MyIntent(IDialogContext context, LuisResult result)
        {
            await context.PostAsync($"Ok, let me look for this item."); //
            // Cortana takes picture of item.
            // Sends picture to custom vision service through server
            // Detects what kind of cereal it is and adds it to an excel or word document.
            await context.PostAsync($"I will add this item to your shopping cart");
            context.Wait(MessageReceived);
        }
    }
}




           
        
