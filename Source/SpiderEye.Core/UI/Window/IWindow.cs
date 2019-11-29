using System;

namespace SpiderEye
{
    /// <summary>
    /// Represents a window.
    /// </summary>
    internal interface IWindow : IDisposable
    {
        /// <summary>
        /// Fires before the window gets closed.
        /// </summary>
        event CancelableEventHandler Closing;

        /// <summary>
        /// Fires after the window has closed.
        /// </summary>
        event EventHandler Closed;

        /// <summary>
        /// Gets or sets the window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the window size.
        /// </summary>
        Size Size { get; set; }

        /// <summary>
        /// Gets or sets the minimum window size.
        /// </summary>
        Size MinSize { get; set; }

        /// <summary>
        /// Gets or sets the maximum window size.
        /// </summary>
        Size MaxSize { get; set; }

        /// <summary>
        /// Gets or sets the background color of the window.
        /// </summary>
        string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window can be resized or not.
        /// </summary>
        bool CanResize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the window title
        /// should be updated when the browser title does.
        /// </summary>
        bool UseBrowserTitle { get; set; }

        /// <summary>
        /// Gets or sets the default window icon.
        /// </summary>
        AppIcon Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the scripting interface
        /// between browser and window is enabled.
        /// </summary>
        bool EnableScriptInterface { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dev tools are enabled or not.
        /// </summary>
        bool EnableDevTools { get; set; }

        /// <summary>
        /// Gets the webview of this window.
        /// </summary>
        IWebview Webview { get; }

        /// <summary>
        /// Shows this window.
        /// </summary>
        void Show();

        /// <summary>
        /// Closes this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Sets the window state.
        /// </summary>
        /// <param name="state">The state to set.</param>
        void SetWindowState(WindowState state);
    }
}