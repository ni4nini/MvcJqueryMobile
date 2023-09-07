namespace MvcJqueryMobile.Migrations
{
    using MvcJqueryMobile.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcJqueryMobile.Models.MobileContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcJqueryMobile.Models.MobileContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Heroes.AddOrUpdate(
                x => x.Id,
                new Hero { Id = 1, PageId = "page_Zilean", Header = "時光守護者 極靈", Footer = "Zilean 極靈", Introduction = "極靈是時光守護者，可以扭曲任意英雄的時光，可以對友方英雄或敵方英雄施放。", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg", ImageAlt = "Zilean", VideoUrl = "https://www.youtube.com/embed/_Jc7bZZlGIo" },
                new Hero { Id = 2, PageId = "page_Teemo", Header = "迅捷斥候 提摩", Footer = "Teemo 提摩", Introduction = "提摩的代表武器－吹箭，使用了採集於庫莽古叢林中的劇烈猛毒。", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg", ImageAlt = "Teemo", VideoUrl = "https://www.youtube.com/embed/Qj48qHM1MXE" },
                new Hero { Id = 3, PageId = "page_Sona", Header = "琴仙 索娜", Footer = "Sona 索娜", Introduction = "索娜演奏的旋律能讓靈魂起舞，而她的沉寂卻如撕心裂肺。", ImageUrl = "http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_4.jpg", ImageAlt = "Sona", VideoUrl = "https://www.youtube.com/embed/MAiOAert8us" }
            );

            context.Cars.AddOrUpdate(
                x => x.Id,
                new Car { Id = 1, Name = "Mercedes-AMG S63", Price = 145695, ImageUrl = "Mercedes_AMG_S63.jpg", Category = "轎車" },
                new Car { Id = 2, Name = "Audi S8", Price = 116875, ImageUrl = "Audi_S8.jpg", Category = "轎車" },
                new Car { Id = 3, Name = "BMW M3", Price = 66495, ImageUrl = "BMW_M3.jpg", Category = "轎車" },
                new Car { Id = 4, Name = "Alfa Romeo Giulia Quadrifoglio", Price = 73595, ImageUrl = "AlfaRomeo_GiuliaQuadrifoglio.jpg", Category = "轎車" },
                new Car { Id = 5, Name = "MercedesBenz GLS Class", Price = 68045, ImageUrl = "MercedesBenz_GLS.jpg", Category = "SUV" },
                new Car { Id = 6, Name = "Porsche Cayenne", Price = 60650, ImageUrl = "Porsche_Cayenne.jpg", Category = "SUV" },
                new Car { Id = 7, Name = "Honda CR-V", Price = 24985, ImageUrl = "Honda_CRV.jpg", Category = "SUV" },
                new Car { Id = 8, Name = "Bugatti Chiron", Price = 2998000, ImageUrl = "Bugatti_Chiron.jpg", Category = "跑車" },
                new Car { Id = 9, Name = "Lamborghini Huracan", Price = 203295, ImageUrl = "Lamborghini_Huracan.jpg", Category = "跑車" },
                new Car { Id = 10, Name = "Porsche 718 Boxster", Price = 57050, ImageUrl = "Porsche_718Boxster.jpg", Category = "跑車" }
            );

            context.Chairs.AddOrUpdate(
                x => x.Id,
                new Chair { Id = 1, Name = "樺木餐椅", Price = 2499, ImageUrl = "80400754.png", Category = "餐椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/non-upholstered-chairs/ronninge-art-80400754" },
                new Chair { Id = 2, Name = "EKEDALEN橡木餐椅", Price = 2249, ImageUrl = "99429352.png", Category = "餐椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/upholstered-chairs/ekedalen-spr-99429352" },
                new Chair { Id = 3, Name = "HATTEFJÄLL辦公扶手椅", Price = 7490, ImageUrl = "40538961.png", Category = "電腦椅", Url="https://www.ikea.com.tw/zh/products/office-workspace/office-chairs/hattefjall-art-40538961" },
                new Chair { Id = 4, Name = "BLECKBERGET電腦椅", Price = 1499, ImageUrl = "30483049.png", Category = "電腦椅", Url="https://www.ikea.com.tw/zh/products/home-workspace/home-work-chairs/bleckberget-art-30483049" },
                new Chair { Id = 5, Name = "DALFRED黑色吧台椅", Price = 1799, ImageUrl = "40161595.png", Category = "吧台椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/bar-stools/dalfred-art-40161595" },
                new Chair { Id = 6, Name = "RÖNNINGE樺木吧台椅", Price = 2499, ImageUrl = "10512905.png", Category = "吧台椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/bar-stools/ronninge-art-10512905" },
                new Chair { Id = 7, Name = "FRANKLIN黑色折疊吧台椅", Price = 1499, ImageUrl = "40406786.png", Category = "吧台椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/bar-stools/franklin-art-40406786" },
                new Chair { Id = 8, Name = "透明餐椅", Price = 2299, ImageUrl = "90560978.png", Category = "餐椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/non-upholstered-chairs/stein-art-90560978" },
                new Chair { Id = 9, Name = "NILSOVE白色籐製餐椅", Price = 3099, ImageUrl = "29304124.png", Category = "餐椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/non-upholstered-chairs/nilsove-norna-spr-29304124" },
                new Chair { Id = 10, Name = "BALTSAR旋轉椅", Price = 4999, ImageUrl = "90532136.png", Category = "餐椅", Url="https://www.ikea.com.tw/zh/products/dining-seating/upholstered-chairs/baltsar-art-90532136" }
            );

        }
    }
}
