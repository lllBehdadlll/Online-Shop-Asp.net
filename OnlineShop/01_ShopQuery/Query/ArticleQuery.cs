﻿using _0_Framework.Application;
using _01_ShopQuery.Contracts.Article;
using BlogManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ShopQuery.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly BlogContext _context;
        //private readonly CommentContext _commentContext;
        //public ArticleQuery(BlogContext context, CommentContext commentContext)
        public ArticleQuery(BlogContext context)
        {
            _context = context;
            //_commentContext = commentContext;
        }


 

            public List<ArticleQueryModel> LatestArticles()
        {
            return _context.Articles
                .Include(x => x.Category)
                .Where(x => x.PublishDate <= DateTime.Now)
                .Select(x => new ArticleQueryModel
                {
                    Title = x.Title,
                    Slug = x.Slug,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    PublishDate = x.PublishDate.ToFarsi(),
                    ShortDescription = x.ShortDescription,
                }).ToList();
        }
    }
}
