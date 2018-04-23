using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public class ToolTipHelper
    {
        BarManager manager;
        BarItemLink _TooltipItem;

        public ToolTipHelper(BarManager manager)
        {
            this.manager = manager;
        }

        public bool ShowToolTipInMenuItems
        {
            set
            {
                manager.HighlightedLinkChanged -= OnHighlightedLinkChanged;
                if (value)
                    manager.HighlightedLinkChanged += OnHighlightedLinkChanged;
            }
        }

    
        private BarItemLink TooltipItem
        {
            get { return _TooltipItem; }
            set
            {
                _TooltipItem = value;
                OnToolTipItemChanged();
            }
        }

        private void OnHighlightedLinkChanged(object sender, DevExpress.XtraBars.HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && e.Link.IsLinkInMenu)
                TooltipItem = e.Link;
            else
                TooltipItem = null;
        }

        private void OnToolTipItemChanged()
        {
            ToolTipController.DefaultController.HideHint();
            if (TooltipItem != null)
                ShowItemSuperTip(TooltipItem);
        }
        private void ShowItemSuperTip(BarItemLink item)
        {
            ToolTipControllerShowEventArgs args = new ToolTipControllerShowEventArgs();
            args.ToolTipType = ToolTipType.SuperTip;
            args.SuperTip = new SuperToolTip();
            args.SuperTip.Items.Add(item.Item.Hint);
            ToolTipController.DefaultController.ShowHint(args);

        }


    }
}
