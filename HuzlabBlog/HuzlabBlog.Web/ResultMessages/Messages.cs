namespace HuzlabBlog.Web.ResultMessages
{
	public static class Messages
	{
		public static class Article
		{
			public static string Add(string articleTitle)
			{
				return $"{articleTitle}, Başarıyla Eklendi!";
			}
			public static string Update(string articleTitle)
			{
				return $"{articleTitle}, Başarıyla Güncellendi!";
			}
            public static string Delete(string articleTitle)
            {
                return $"{articleTitle}, Başarıyla Silindi!";
            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle}, Başarıyla Çöp Kutusundan Taşındı!!";
            }
        }
		public static class Category
		{
			public static string Add(string categoryName)
			{
				return $"{categoryName}, Başarıyla Eklendi!";
			}
			public static string Update(string categoryName)
			{
				return $"{categoryName}, Başarıyla Güncellendi!";
			}
			public static string Delete(string categoryName)
			{
				return $"{categoryName}, Başarıyla Silindi!";
			}
            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName}, Başarıyla Çöp Kutusundan Taşındı!!";
            }
        }
		public static class AppUser
		{
			public static string Add(string userName)
			{
				return $"{userName}, Başarıyla Eklendi!";
			}
			public static string Update(string userName)
			{
				return $"{userName}, Başarıyla Güncellendi!";
			}
			public static string Delete(string userName)
			{
				return $"{userName}, Başarıyla Silindi!";
			}
		}
	}
}
