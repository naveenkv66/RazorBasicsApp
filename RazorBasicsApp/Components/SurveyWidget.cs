using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorBasicsApp.Components
{
    public class SurveyWidget : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int ProductId)
        {
            List<SurveyProduct> surveyProducts = new List<SurveyProduct>()
            {
                new SurveyProduct(){ Id = 1, Name="Life Size Cutouts",VoteCount = 8},
                new SurveyProduct(){ Id = 2, Name="Glow in the Dark Pens",VoteCount = 4},
                new SurveyProduct(){ Id = 3, Name="Flags",VoteCount = 1},
                new SurveyProduct(){ Id = 4, Name="Banners",VoteCount = 5}
            };

            if (ProductId > 0)
            {
                surveyProducts.FirstOrDefault(item => item.Id == ProductId).VoteCount += 1;
                return View("Result",surveyProducts);
            }
            

            await Task.Delay(0);
            return View(surveyProducts);
        }
    }

    public class SurveyProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VoteCount { get; set; }
    }
         
}
