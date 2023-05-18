using Microsoft.EntityFrameworkCore;

namespace FPTBookStore.Models
{
	public class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			if (!context.Products.Any())
			{
				context.Products.AddRange(
					new Product
					{
						Name = "Such A Fun Age",                       
                        Description = "A striking and surprising debut novel from an exhilarating new voice, Such a Fun Age is a page-turning and big-hearted story about race and privilege, set around a young black babysitter, her well-intentioned employer, and a surprising connection that threatens to undo them both.",
						Category = "Comedy",
						Price = 275,
						Picture = "/images/1.jpg"
					},
					new Product
					{
						Name = "Me Talk Pretty One Day",
						Description = "Anyone that has read NAKED and BARREL FEVER, or heard David Sedaris speaking live or on the radio will tell you that a new collection from him is cause for jubilation. His recent move to Paris from New York inspired these hilarious new pieces, including 'Me Talk Pretty One Day', about his attempts to learn French from a sadistic teacher who declares that 'every day spent with you is like having a caesarean section'. His family is another inspiration. ",
						Category = "Comedy",
						Price = 48.95m,
                        Picture = "/images/2.jpg"

                    },
					 new Product
					 {
						 Name = "And Away... ",
						 Description = "Bob Mortimer’s life was trundling along happily until suddenly in 2015 he was diagnosed with a heart condition that required immediate surgery and forced him to cancel an upcoming tour. The episode unnerved him, but forced him to reflect on his life so far. This is the framework for his hilarious and moving memoir, And Away…",
						 Category = "Comedy",
						 Price = 19.50m,
                         Picture = "/images/3.jpg"

                     },
					 new Product
					 {
						 Name = "Foreskin’s Lament: A Memoir  ",
						 Description = "Shalom Auslander was raised with a terrified respect for God. Even as he grew up and was estranged from his community, his religion and its traditions, he could not find the path to a life where he didn’t struggle daily with the fear of God’s formidable wrath. Foreskin’s Lament reveals Auslander’s “painfully, cripplingly, incurably, miserably religious” youth in a strict, socially isolated Orthodox Jewish community, and recounts his rebellion and efforts to make a new life apart from it. His combination of unrelenting humor and anger renders a rich and fascinating portrait of a man grappling with his faith and family",
						 Category = "Comedy",
						 Price = 34.95m,
                         Picture = "/images/4.jpg"
                     },
					 new Product
					 {
						 Name = "The Adulterants ",
						 Description = "The Adulterants would be a coming-of-age story if its protagonist could only forget that he is thirty-three years old. Throughout a series of escalating catastrophes, our deadpan antihero keeps up a merciless mental commentary on the foibles and failings of those around him, and the vicissitudes of modern urban life: internet trolls, buy-to-let landlords, open marriages, and the threat posed by more sensitive men. But the wonder of The Adulterants is how we feel ourselves rooting for Ray even as we acknowledge that he deserves everything he gets.",
						 Category = "Comedy",
						 Price = 79500,
                         Picture = "/images/5.jpg"
                     },
					 new Product
					 {
						 Name = "The Proposal",
						 Description = "The author of The Wedding Date serves up a novel about what happens when a public proposal doesn't turn into a happy ending, thanks to a woman who knows exactly how to make one on her own...",
						 Category = "Romance",
						 Price = 16,
                         Picture = "/images/6.jpg"
                     },
					 new Product
					 {
						 Name = "The Hating Game",
						 Description = "Lucy Hutton and Joshua Templeman hate each other. Not dislike. Not begrudgingly tolerate. Hate. And they have no problem displaying their feelings through a series of ritualistic passive aggressive maneuvers as they sit across from each other, executive assistants to co-CEOs of a publishing company. Lucy can’t understand Joshua’s joyless, uptight, meticulous approach to his job. Joshua is clearly baffled by Lucy’s overly bright clothes, quirkiness, and Pollyanna attitude. But the tension between Lucy and Joshua has also reached its boiling point, and Lucy is discovering that maybe she doesn’t hate Joshua. And maybe, he doesn’t hate her either. Or maybe this is just another game",
						 Category = "Romance",
						 Price = 29.95m,
                         Picture = "/images/7.jpg"

                     },
					 new Product
					 {
						 Name = "Love at First Like",
						 Description = "Eliza Roth and her sister Sophie co-own a jewelry shop in Brooklyn. One night, after learning of an ex’s engagement, Eliza accidentally posts a photo of herself wearing a diamond ring on that finger to her Instagram account beloved by 100,000 followers. Sales skyrocket, press rolls in, and Eliza learns that her personal life is good for business. So she has a choice: continue the ruse or clear up the misunderstanding. With mounting financial pressure, Eliza sets off to find a fake fiancé.",
						 Category = "Romance",
						 Price = 75,
                         Picture = "/images/8.jpg"

                     },
					 new Product
					 {
						 Name = "Eleanor & Park",
						 Description = "“Bono met his wife in high school,” Park says.\r\n“So did Jerry Lee Lewis,” Eleanor answers.\r\n“I’m not kidding,” he says.\r\n“You should be,” she says, “we’re 16.”\r\n“What about Romeo and Juliet?”\r\n“Shallow, confused, then dead.”\r\n“I love you,” Park says.\r\n",
						 Category = "Romance",
						 Price = 1200,
                         Picture = "/images/9.jpg"


                     },
                     new Product
                     {
                         Name = "Call Me by Your Name",
                         Description = "Call Me by Your Name is the story of a sudden and powerful romance that blossoms between an adolescent boy and a summer guest at his parents' cliff-side mansion on the Italian Riviera. Unprepared for the consequences of their attraction, at first each feigns indifference. But during the restless summer weeks that follow, unrelenting buried currents of obsession and fear, fascination and desire, intensify their passion as they test the charged ground between them. ",
                         Category = "Romance",
                         Price = 75,
                         Picture = "/images/10.jpg"

                     },
                     new Product
                     {
                         Name = "The Notebook",
                         Description = "Set amid the austere beauty of the North Carolina coast begins the story of Noah Calhoun, a rural Southerner recently returned from the Second World War. Noah is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer they spent together, Noah is content to live with only memories...until she unexpectedly returns to his town to see him once again.",
                         Category = "Romance",
                         Price = 75,
                         Picture = "/images/11.jpg"

                     },
                     new Product
                     {
                         Name = "Wrong Place Wrong Time",
                         Description = "Another ingeniously plotted genre-bender… McAllister succeeds in making us care, and the result is a tour de force.” — The Guardian.\r\n“This entertaining look at motherhood and memory will resonate with many.",
                         Category = "Thriller",
                         Price = 75,
                         Picture = "/images/12.jpg"

                     },
                     new Product
                     {
                         Name = "The Island",
                         Description = "INSTANT NEW YORK TIMES BESTSELLER · A NEW YORK TIMES \"BEST THRILLER OF 2022",
                         Category = "Thriller",
                         Price = 75,
                         Picture = "/images/13.jpg"

                     },
                     new Product
                     {
                         Name = "These Women",
                         Description = "A Recommended Book From The New York Times Book Review * The Washington Post * Vogue * Entertainment Weekly * Elle * People * Marie Claire * Vulture * The Minneapolis Star-Tribune * LitHub * Crime Reads * PopSugar * AARP * Book Marks * South Florida Sun Sentinel. From the award-winning author of Wonder Valley and Visitation Street comes a serial killer story like you’ve never seen before—a literary thriller of female empowerment and social change",
                         Category = "Thriller",
                         Price = 75,
                         Picture = "/images/14.jpg"

                     },
                     new Product
                     {
                         Name = "A Mother Would Know ",
                         Description = "Do we ever really know our children? Amber Garza invites readers to untangle the web of a family just like yours—or are they? This thriller will have you triple-guessing yourself",
                         Category = "Thriller",
                         Price = 75,
                         Picture = "/images/15.jpg"

                     },
                     new Product
                     {
                         Name = "The Lost Man",
                         Description = "Dark, suspenseful, and deeply atmospheric, The Lost Man is the highly anticipated next book from the bestselling and award-winning Jane Harper, author of The Dry and Force of Nature",
                         Category = "Thriller",
                         Price = 75,
                         Picture = "/images/16.jpg"

                     },
                     new Product
                     {
                         Name = "In the Lives of Puppets",
                         Description = "New York Times bestselling author TJ Klune invites you deep into the heart of a peculiar forest and on the extraordinary journey of a family assembled from spare parts.",
                         Category = "Fantasy",
                         Price = 75,
                         Picture = "/images/17.jpg"

                     },
                     new Product
                     {
                         Name = "Bewitched",
                         Description = "At age twenty, Selene Bowers desperately hopes to be accepted into Henbane Coven, an academy for young witches. Since one of the requirements for entry is to connect with her powers via a quest through the wilderness, Selene books a trip to South America. When a nefarious supernatural force tries to drag her plane from the sky, Selene's magic awakens to save her life―at a cost. Using her powers devours her memories, one by one.",
                         Category = "Fantasy",
                         Price = 75,
                         Picture = "/images/18.jpg"

                     },
                     new Product
                     {
                         Name = "Ascension",
                         Description = "A mind-bending speculative thriller in which the sudden appearance of a mountain in the middle of the Pacific Ocean leads a group of scientists to a series of jaw-dropping revelations that challenge the notion of what it means to be human",
                         Category = "Fantasy",
                         Price = 75,
                         Picture = "/images/19.jpg"

                     },
                      new Product
                      {
                          Name = "Divine Rivals",
                          Description = "When two young rival journalists find love through a magical connection, they must face the depths of hell, in a war among gods, to seal their fate forever.",
                          Category = "Fantasy",
                          Price = 75,
                          Picture = "/images/20.jpg"

                      },
                       new Product
                       {
                           Name = "Silver in the Bone",
                           Description = "A series opener inspired by Arthurian legend and fueled by love, revenge, and pure adrenaline!\r\nTamsin Lark didn’t ask to be a Hollower. As a mortal with no magical talent, she was never meant to break into ancient crypts, or compete with sorceresses and Cunningfolk for the treasures inside. But after her thieving foster father disappeared without so much as a goodbye, it was the only way to keep herself—and her brother, Cabell—alive.\r\n",
                           Category = "Fantasy",
                           Price = 75,
                           Picture = "/images/21.jpg"

                       }

                    );
				context.SaveChanges();
			}
		}
	}
}