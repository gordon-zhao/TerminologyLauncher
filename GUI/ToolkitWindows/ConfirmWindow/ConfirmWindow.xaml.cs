﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using TerminologyLauncher.GUI.Annotations;
using TerminologyLauncher.I18n.TranslationObjects.GUITranslations;

namespace TerminologyLauncher.GUI.ToolkitWindows.ConfirmWindow
{
    /// <summary>
    /// Interaction logic for ConfirmWindow.xaml
    /// </summary>
    public sealed partial class ConfirmWindow : INotifyPropertyChanged
    {
        private string ContentStringValue;
        public ConfirmWindowTranslation Translation
        {
            get
            {
                return
                    I18n.TranslationProvider.TranslationProviderInstance.TranslationObject.GuiTranslation
                        .ConfirmWindowTranslation;
            }
        }
        public String ContentString
        {
            get { return this.ContentStringValue; }
            set
            {
                this.ContentStringValue = value;
                this.OnPropertyChanged();
            }
        }
        internal ConfirmWindow(Window owner, String title, String content)
        {
            this.Owner = owner;
            this.ContentString = content;
            this.InitializeComponent();
            if (owner != null)
            {
                this.Owner = owner;
                this.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            }
            else
            {
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            }
            this.Title = title;
            this.IsCanceled = false;
            this.OnPropertyChanged();
        }
        private Boolean IsCanceled { get; set; }

        public new Boolean? ShowDialog()
        {
            base.ShowDialog();
            return !this.IsCanceled;
        }

        public void CrossThreadClose()
        {
            this.Dispatcher.Invoke(() =>
            {
                this.IsCanceled = true;
                this.Close();
            });
        }

        private void OnDrag(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) this.DragMove();
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.IsCanceled = true;
            this.Close();
        }

        private void ConfirmButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
