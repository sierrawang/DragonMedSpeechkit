//
//  LoginDialog.cs
//  SpeechAnywhereSample
//
//  Copyright 2011-2018 Nuance Communications, Inc. All rights reserved.
//

using System;
using System.Windows.Forms;
// Using the Windows Forms API for accessing the Speech Bar functionality. As custom control applications are GUI neutral, the WPF API could also be used.
using Nuance.SpeechAnywhere.WindowsForms;

namespace S_SpeechAnywhere
{
	public partial class LoginDialog : Form
	{
        public string Username
        {
            get { return tbUsername.Text; } 
        }
		public LoginDialog()
		{
			InitializeComponent();
            // Set the initial position to 100 pixels away from the upper left corner of the main screen, both in X and Y position
            SpeechBar.SharedSpeechBar.SetInitialPosition(100, 100, true, true);
            // To position the speech bar relative to the bottom and right of the screen, pass "false" for the respective axis.
            // This way, the distance is interpreted between the lower and/or the right edge of the speech bar.
            // Find out the screen size here and position the lower and/or right edge of the speech bar accordingly. 
        }

        private void buttonCustomizeSpeechBar_Click(object sender, EventArgs e)
        {
            // Override the default speech bar images by custom ones

            // The background of the speech bar. 
            // Minimum size is 324 x 56 pixels. Maximum size is this value plus 10% along both axes; i.e. 356 x 61 pixels.
            // This is useful for round corner toolbar images.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.SpeechBar, Properties.Resources.toolbar);

            // The background images of the speech bar's buttons, in their respective states. All button images are 44 x 44 pixels.

            // Button background of the record button, when not recording and with no user interaction. A background color value of R=26, G=107, B=150 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOffNormal, Properties.Resources.recbutton_default);
            // Button background of the record button, when not recording and the mouse hovers over it. A background color value of R=35, G=135, B=190 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOffHover, Properties.Resources.recbutton_default_hover);
            // Button background of the record button, when not recording and it is being clicked with the mouse. A background color value of R=20, G=85, B=120 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOffPressed, Properties.Resources.recbutton_default_pressed);

            // Button background of the record button, when recording and with no user interaction. A background color value of R=252, G=1, B=2 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOnNormal, Properties.Resources.recbutton_recording);
            // Button background of the record button, when recording and the mouse hovers over it. A background color value of R=255, G=98, B=98 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOnHover, Properties.Resources.recbutton_recording_hover);
            // Button background of the record button, when recording and it is being clicked with the mouse. A background color value of R=193, G=2, B=2 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.RecordButtonOnPressed, Properties.Resources.recbutton_recording_pressed);

            // Button background of the options ("Nuance flame") button, with no user interaction. A background color value of R=26, G=107, B=150 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.OptionsButtonNormal, Properties.Resources.optionsbutton);
            // Button background of the record button, when the mouse hovers over it. A background color value of R=35, G=135, B=190 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.OptionsButtonHover, Properties.Resources.optionsbutton_hover);
            // Button background of the record button, when it is being clicked with the mouse. A background color value of R=20, G=85, B=120 will match that of the inner image of the button.
            SpeechBar.SharedSpeechBar.SetBackgroundImage(Nuance.SpeechAnywhere.BackgroundImageType.OptionsButtonPressed, Properties.Resources.optionsbutton_pressed);
        }

	}
}
