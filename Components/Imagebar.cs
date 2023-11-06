﻿using AdvancedEShopper.Data;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedEShopper.Components
{
    public class Imagebar : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public Imagebar(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(_context.Categories.ToList());
        }
    }
}
