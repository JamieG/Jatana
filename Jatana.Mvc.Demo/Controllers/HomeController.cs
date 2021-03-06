﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

namespace Jatana.Mvc.Demo.Controllers
{
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View("~/Views/index.njk");
        }
    }

    [RoutePrefix("docs")]
    public class DocsController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            var modelBuilder = new DocsLayoutViewModelBuilder();
            var viewModel = modelBuilder.Build();
           
            return View("~/Views/docs/index.njk", viewModel);
        }
    }

    [RoutePrefix("docs/getting-started")]
    public class GettingStartedController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            var modelBuilder = new DocsLayoutViewModelBuilder();
            var viewModel = modelBuilder.Build();

            return View("~/Views/docs/getting-started/index.njk", viewModel);
        }
    }

    public class DocsLayoutViewModelBuilder
    {
        public DocsLayoutViewModel Build()
        {
            var json = @"{
  'version': '0.0.1',
  'docs_sections': [
    { 'id': 'getting-started', 'title': 'Getting Started', 'ready': true },
    { 'id': 'core', 'title': 'Core', 'ready': true },
    { 'id': 'components', 'title': 'Components', 'ready': true },
    { 'id': 'roadmap', 'title': 'Roadmap', 'ready': false }
  ],
  'docs_pages': [
    {
      'category': '',
      'section': 'getting-started',
      'items': [
        { 'id': 'index', 'title': 'Installation', 'section': 'getting-started', 'ready': true },
        { 'id': 'environment', 'title': 'Dev environment', 'section': 'getting-started', 'ready': true },
        { 'id': 'file-structure', 'title': 'File structure', 'section': 'getting-started', 'ready': true },
        { 'id': 'stylesheets', 'title': 'Stylesheets', 'section': 'getting-started', 'ready': true },
        { 'id': 'javascript', 'title': 'Javascript', 'section': 'getting-started', 'ready': true },
        { 'id': 'html', 'title': 'HTML templates', 'section': 'getting-started', 'ready': false },
        { 'id': 'icons', 'title': 'Icons', 'section': 'getting-started', 'ready': false },
        { 'id': 'support', 'title': 'Browser & device support', 'section': 'getting-started', 'ready': false }
      ]
    },
    {
      'category': 'Defaults',
      'section': 'core',
      'items': [
        { 'id': 'base', 'title': 'Base', 'section': 'core', 'ready': true },
        { 'id': 'breakpoints', 'title': 'Breakpoints', 'section': 'core', 'ready': true },
        { 'id': 'font-sizes', 'title': 'Font sizes', 'section': 'core', 'ready': true },
        { 'id': 'print', 'title': 'Print', 'section': 'core', 'ready': true }
      ]
    },
    {
      'category': 'Objects',
      'section': 'core',
      'items': [
        { 'id': 'site', 'title': 'Site', 'section': 'core', 'ready': true },
        { 'id': 'container', 'title': 'Container', 'section': 'core', 'ready': true },
        { 'id': 'grid', 'title': 'Grid', 'section': 'core', 'ready': true },
        { 'id': 'size', 'title': 'Size', 'section': 'core', 'ready': true },
        { 'id': 'section', 'title': 'Section', 'section': 'core', 'ready': true },
        { 'id': 'media', 'title': 'Media', 'section': 'core', 'ready': true },
        { 'id': 'cover', 'title': 'Cover', 'section': 'core', 'ready': true }
      ]
    },
    {
      'category': 'Elements',
      'section': 'core',
      'items': [
        { 'id': 'list', 'title': 'List', 'section': 'core', 'ready': true },
        { 'id': 'table', 'title': 'Table', 'section': 'core', 'ready': true },
        { 'id': 'form', 'title': 'Form', 'section': 'core', 'ready': true },
        { 'id': 'definition', 'title': 'Definition', 'section': 'core', 'ready': true },
        { 'id': 'text', 'title': 'Text', 'section': 'core', 'ready': false }
      ]
    },
    {
      'category': 'Navigation',
      'section': 'core',
      'items': [
        { 'id': 'menu', 'title': 'Menu', 'section': 'core', 'ready': true },
        { 'id': 'breadcrumbs', 'title': 'Breadcrumbs', 'section': 'core', 'ready': true },
        { 'id': 'skip-link', 'title': 'Skip link', 'section': 'core', 'ready': true },
        { 'id': 'back-to-top', 'title': 'Back to top', 'section': 'core', 'ready': false }
      ]
    },
    {
      'category': 'Navigation',
      'section': 'components',
      'items': [
        { 'id': 'bookmarks', 'title': 'Bookmarks', 'section': 'components', 'ready': true },
        { 'id': 'dropdown', 'title': 'Dropdown', 'section': 'components', 'ready': false }
      ]
    },
    {
      'category': 'Common',
      'section': 'core',
      'items': [
        { 'id': 'icon', 'title': 'Icon', 'section': 'core', 'ready': true },
        { 'id': 'button', 'title': 'Button', 'section': 'core', 'ready': true },
        { 'id': 'panel', 'title': 'Panel', 'section': 'core', 'ready': true },
        { 'id': 'close', 'title': 'Close', 'section': 'core', 'ready': true },
        { 'id': 'badge', 'title': 'Badge', 'section': 'core', 'ready': true },
        { 'id': 'overlay', 'title': 'Overlay', 'section': 'core', 'ready': false },
        { 'id': 'tooltip', 'title': 'Tooltip', 'section': 'core', 'ready': true }
      ]
    },
    {
      'category': 'Common',
      'section': 'components',
      'items': [
        { 'id': 'alert', 'title': 'Alert', 'section': 'components', 'ready': false },
        { 'id': 'responsive-img', 'title': 'Responsive images', 'section': 'components', 'ready': true }
      ]
    },
    {
      'category': 'Modules',
      'section': 'core',
      'items': [
        { 'id': 'helpers', 'title': 'Helpers', 'section': 'core', 'ready': true },
        { 'id': 'breakpoint-mod', 'title': 'Breakpoint', 'section': 'core', 'ready': true },
        { 'id': 'toggle', 'title': 'Toggle', 'section': 'core', 'ready': true },
        { 'id': 'sticky', 'title': 'Sticky', 'section': 'core', 'ready': false },
        { 'id': 'cookies', 'title': 'Cookies', 'section': 'core', 'ready': false },
        { 'id': 'switcher', 'title': 'Switcher', 'section': 'core', 'ready': true }
      ]
    }
  ],
  'icons': [
    { 'id': 'archive' },
    { 'id': 'arrow-down' },
    { 'id': 'arrow-left' },
    { 'id': 'arrow-right' },
    { 'id': 'arrow-up' },
    { 'id': 'bell' },
    { 'id': 'calendar' },
    { 'id': 'camera' },
    { 'id': 'cart' },
    { 'id': 'chart' },
    { 'id': 'check' },
    { 'id': 'chevron-down' },
    { 'id': 'chevron-left' },
    { 'id': 'chevron-right' },
    { 'id': 'chevron-up' },
    { 'id': 'clock' },
    { 'id': 'close' },
    { 'id': 'close-o' },
    { 'id': 'comment' },
    { 'id': 'credit-card' },
    { 'id': 'envelope' },
    { 'id': 'exclamation' },
    { 'id': 'external-link' },
    { 'id': 'eye' },
    { 'id': 'gear' },
    { 'id': 'heart' },
    { 'id': 'image' },
    { 'id': 'like' },
    { 'id': 'link' },
    { 'id': 'location' },
    { 'id': 'lock' },
    { 'id': 'minus' },
    { 'id': 'navicon' },
    { 'id': 'paperclip' },
    { 'id': 'pencil' },
    { 'id': 'play' },
    { 'id': 'plus' },
    { 'id': 'pointer' },
    { 'id': 'question' },
    { 'id': 'redo' },
    { 'id': 'refresh' },
    { 'id': 'retweet' },
    { 'id': 'sc-facebook' },
    { 'id': 'sc-github' },
    { 'id': 'sc-google-plus' },
    { 'id': 'sc-instagram' },
    { 'id': 'sc-linkedin' },
    { 'id': 'sc-pinterest' },
    { 'id': 'sc-skype' },
    { 'id': 'sc-soundcloud' },
    { 'id': 'sc-telegram' },
    { 'id': 'sc-tumblr' },
    { 'id': 'sc-twitter' },
    { 'id': 'sc-vimeo' },
    { 'id': 'sc-youtube' },
    { 'id': 'search' },
    { 'id': 'share-apple' },
    { 'id': 'share-google' },
    { 'id': 'spinner' },
    { 'id': 'spinner-2' },
    { 'id': 'spinner-3' },
    { 'id': 'star' },
    { 'id': 'tag' },
    { 'id': 'trash' },
    { 'id': 'trophy' },
    { 'id': 'undo' },
    { 'id': 'unlock' },
    { 'id': 'user' }
  ]
}
";

            return JsonConvert.DeserializeObject<DocsLayoutViewModel>(json);
        }
    }

    public class DocsSection
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }

    public class Item
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("ready")]
        public bool Ready { get; set; }
    }

    public class DocsPage
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("items")]
        public List<Item> Items { get; set; }
    }

    public class Icon
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class DocsLayoutViewModel
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("docs_sections")]
        public List<DocsSection> DocsSections { get; set; } = new List<DocsSection>();

        [JsonProperty("docs_pages")]
        public List<DocsPage> DocsPages { get; set; } = new List<DocsPage>();

        [JsonProperty("icons")]
        public List<Icon> Icons { get; set; } = new List<Icon>();
    }
}