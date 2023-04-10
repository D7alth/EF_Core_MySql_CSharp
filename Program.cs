using EFCoreMySQL;

BlogDataContext context = new BlogDataContext();

var alberth = new Author {Name = "Alberth", Email = "alberth@gmail.com"};
context.Authors.Add(alberth);

var post = new Post {Title = "Hello World", Content = "testing EF core with mysql", Author = alberth};
context.Posts.Add(post);

context.SaveChanges();

var posts = context.Posts;

foreach (var p in posts){
    Console.WriteLine(p.Title);
}


