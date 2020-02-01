using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class BlogDbInitializer : DropCreateDatabaseAlways<BlogContext>
    {

        protected override void Seed(BlogContext db)
        {
            db.Articles.Add(new Article { Name = "Atr1", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam id mollis purus. Pellentesque imperdiet felis odio, in hendrerit nisi semper ac. Duis mauris felis, sodales euismod ex at, tempor condimentum tortor. Maecenas vel faucibus nunc. Maecenas a nisi sed lectus tempor venenatis. Curabitur id velit imperdiet, ultrices mi a, consequat lorem. Vestibulum non consectetur libero, ac sagittis odio. Sed at lorem nec mi varius porta. Pellentesque interdum massa vel magna ultrices placerat a ac diam. Pellentesque neque libero, iaculis ac vulputate et, varius vitae urna. Curabitur rutrum eget lacus dignissim luctus. Cras accumsan in lectus in sollicitudin. Morbi enim mi, vestibulum eu sapien quis, tristique rutrum ligula. Quisque nec ante dui. ", Date="01.02.2020" });
            db.Articles.Add(new Article { Name = "Article", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam id mollis purus. Pellentesque imperdiet felis odio, in hendrerit nisi semper ac. Duis mauris felis, sodales euismod ex at, tempor condimentum tortor. Maecenas vel faucibus nunc. Maecenas a nisi sed lectus tempor venenatis. Curabitur id velit imperdiet, ultrices mi a, consequat lorem. Vestibulum non consectetur libero, ac sagittis odio. Sed at lorem nec mi varius porta. Pellentesque interdum massa vel magna ultrices placerat a ac diam. Pellentesque neque libero, iaculis ac vulputate et, varius vitae urna. Curabitur rutrum eget lacus dignissim luctus. Cras accumsan in lectus in sollicitudin. Morbi enim mi, vestibulum eu sapien quis, tristique rutrum ligula. Quisque nec ante dui. ", Date = "01.02.2020" });
            db.Articles.Add(new Article { Name = "Article", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam id mollis purus. Pellentesque imperdiet felis odio, in hendrerit nisi semper ac. Duis mauris felis, sodales euismod ex at, tempor condimentum tortor. Maecenas vel faucibus nunc. Maecenas a nisi sed lectus tempor venenatis. Curabitur id velit imperdiet, ultrices mi a, consequat lorem. Vestibulum non consectetur libero, ac sagittis odio. Sed at lorem nec mi varius porta. Pellentesque interdum massa vel magna ultrices placerat a ac diam. Pellentesque neque libero, iaculis ac vulputate et, varius vitae urna. Curabitur rutrum eget lacus dignissim luctus. Cras accumsan in lectus in sollicitudin. Morbi enim mi, vestibulum eu sapien quis, tristique rutrum ligula. Quisque nec ante dui. ", Date = "01.02.2020" });
            base.Seed(db);
        }

    }
}