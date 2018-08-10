//
//  Program.cs
//  SpeechAnywhereSample
//
//  Copyright 2011 Nuance Communications, Inc. All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Nuance.SpeechAnywhere;

namespace S_SpeechAnywhere
{
	static class Program
	{
        // Convenience defines used for opening the ISession instance and pass it the licensing 
        // information needed. Your partner GUID and organization token will be made available to you via the 
        // Nuance order desk.
        
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            
			// Use a login dialog to obtain a user name for opening a Dragon Medical Server session
			//LoginDialog loginDialog = new LoginDialog();
			//if (loginDialog.ShowDialog()!=DialogResult.OK)
            //    return;
			// We will use the user name from the login dialog for licensing information passed to the Dragon Medical SpeechKit SDK. 
            Session.SharedSession.Open(SierraKeys.username, SierraKeys._organizationToken, SierraKeys._partnerGuid, SierraKeys.programName);
            try
            {
                Application.Run(new Report(args));    // Close the session. 
                                                        // This disconnects and frees any speech recognition resources and user licenses on the Dragon Medical Server.
                Session.SharedSession.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
		
		}
	}
}
