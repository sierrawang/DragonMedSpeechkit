//
//  Report.cs
//  SpeechAnywhereSample
//
//  Copyright 2011-2018 Nuance Communications, Inc. All rights reserved.
//

using System;
using System.Windows.Forms;
using Nuance.SpeechAnywhere;
using Nuance.SpeechAnywhere.Custom;
using System.IO;
using System.Threading.Tasks;
using System.Media;

namespace S_SpeechAnywhere
{
	public partial class Report : Form
	{
        private MyTextControl[] myControls;
		private VuiController vuiController;

        private string outputFolder, outputFile, audioFile;
        private int time;

        public Report(string[] args)
		{
			InitializeComponent();

            outputFolder = args[0];
            outputFile = args[1];
            //audioFile = args[2];
            time = int.Parse(args[2]);

            // my "custom controls" are simple wrappers for the textboxes.
            myControls = new MyTextControl[] { new MyTextControl(transcription) };

            InitializeVuiControllerAsync();
        }
		private async Task InitializeVuiControllerAsync()
		{
			// Add event handlers for RecordingStarted and RecordingStopped events
			Session.SharedSession.RecordingStarted += new RecordingStarted(SharedSession_RecordingStarted);
			Session.SharedSession.RecordingStopped += new RecordingStopped(SharedSession_RecordingStopped);

            vuiController = new VuiController();
			
			// Set the recognition language. This overrides the default setting which is the current UI culture;
			vuiController.Language = "en-us";
			// Enable name field navigation.
			// For example, the first text control is associated with the "medical history" concept. 
			// Users can say "go to medical history" to reach this text control.
			// SetConceptName() must be called before Initialize() to be effective.
			vuiController.SetConceptName(myControls[0], "transcription");

            // Initialize the VuiController by passing Nuance.SpeechAnywhere.Custom.ITextControl[] - which is in this case "myControls"
            vuiController.Open(myControls);
            vuiController.Focused = true;

            //await autoRecordAsync();
        }      

        
        private async System.Threading.Tasks.Task autoRecordAsync()
        {
            //SoundPlayer player = new SoundPlayer();
            //player.SoundLocation = "c:\\Users\\swang\\SpeechToTextSolutions\\audioFiles\\" + audioFile;

            Session.SharedSession.StartRecording();

            //await Task.Delay(1000);

            ////player.PlaySync();

            //try
            //{
            //    player.PlaySync();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Caught exception: " + e.Message);
            //}


            await Task.Delay(time);
            Session.SharedSession.StopRecording();
            saveText();
            Close();
        }

		private void btnRecord_Click(object sender, EventArgs e)
		{
			// Implement a simple toggle recording method. For simplicities sake, we use the current title 
			// of the record toggle button to decide which ISession method to call. 	
			if (btnRecord.Text == "Record")
			{
				Session.SharedSession.StartRecording();
			}
			else
			{
				Session.SharedSession.StopRecording();
			}
		}

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the vui controller instance, once it is no longer needed. Releasing the 
            // vui controller frees speech recognition resources on the server and disconnects 
            // from the service. 
            vuiController.Close();
			// We do not need to take care of recording, as the Dragon Medical SpeechKit will 
            // automatically stop recording for us if it was still running at the time the vui 
            // controller is released. 
        }
		void SharedSession_RecordingStarted()
		{
			// This event occurs in case recording was started.
			// We react by changing the toggle record button title. 
			btnRecord.Text = "Stop";
		}

		void SharedSession_RecordingStopped()
		{
			// This event occurs in case recording was stopped.
			// We react by changing the toggle record button title. 
			btnRecord.Text = "Record";
		}

        private void saveText()
        {
            string pathString = System.IO.Path.Combine(@"c:\Users\swang\SpeechToTextSolutions\Transcriptions", outputFolder);
            pathString = System.IO.Path.Combine(pathString, outputFile);
            String text = transcription.Text;
            text += " (spk1_1)";

            System.IO.File.WriteAllText(pathString, text);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
        
    }

    public class MyTextControl : Nuance.SpeechAnywhere.Custom.ITextControl
    {
        TextBox myCustomTextBox;
        public MyTextControl(TextBox box)
        {
            myCustomTextBox = box;
            box.GotFocus += box_GotFocus;
        }

        void box_GotFocus(object sender, EventArgs e)
        {
            if (GotFocus != null)
            {
                GotFocus(this);
            }
        }

        #region ITextControl Members

        public event Action<object> GotFocus;
        
        public bool Focused
        {
            get
            {
                return myCustomTextBox.Focused;
            }
            set
            {
                myCustomTextBox.Focus();
            }
        }

        public int TextLength
        {
            get { return myCustomTextBox.TextLength; }
        }

        public string NewlineFormatString
        {
            get { return Environment.NewLine; }
        }

        public string ParagraphFormatString
        {
            get { return Environment.NewLine + Environment.NewLine; }
        }

        public void SetSelection(int start, int length)
        {
            myCustomTextBox.SelectionStart = start;
            myCustomTextBox.SelectionLength = length;
        }

        public void GetSelection(ref int start, ref int length)
        {
            start = myCustomTextBox.SelectionStart;
            length = myCustomTextBox.SelectionLength;
        }

        public string GetText(int start, int length)
        {
            return myCustomTextBox.Text;
        }

        public void ReplaceText(int start, int length, string newText)
        {
            SetSelection(start, length);
            myCustomTextBox.SelectedText = newText;
        }

        #endregion
    }
}
