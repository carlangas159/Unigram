﻿using Windows.UI.Xaml;

namespace Unigram.Controls
{
    public class GlyphButton : SimpleButton
    {
        public GlyphButton()
        {
            DefaultStyleKey = typeof(GlyphButton);
        }

        #region Glyph
        public string Glyph
        {
            get { return (string)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }

        public static readonly DependencyProperty GlyphProperty =
            DependencyProperty.Register("Glyph", typeof(string), typeof(GlyphButton), new PropertyMetadata(null));
        #endregion
    }

    public class GlyphHyperlinkButton : SimpleHyperlinkButton
    {
        public GlyphHyperlinkButton()
        {
            DefaultStyleKey = typeof(GlyphHyperlinkButton);
        }

        #region Glyph
        public string Glyph
        {
            get { return (string)GetValue(GlyphProperty); }
            set { SetValue(GlyphProperty, value); }
        }

        public static readonly DependencyProperty GlyphProperty =
            DependencyProperty.Register("Glyph", typeof(string), typeof(GlyphHyperlinkButton), new PropertyMetadata(null));
        #endregion
    }

}
