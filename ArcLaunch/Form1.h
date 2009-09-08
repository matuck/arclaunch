#pragma once


namespace ArcLaunch {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Form1
	///
	/// WARNING: If you change the name of this class, you will need to change the
	///          'Resource File Name' property for the managed resource compiler tool
	///          associated with all .resx files this class depends on.  Otherwise,
	///          the designers will not be able to interact properly with localized
	///          resources associated with this form.
	/// </summary>
	public ref class Form1 : public System::Windows::Forms::Form
	{
	public:
		Form1(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Form1()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::SplitContainer^  splitContainer1;
	private: System::Windows::Forms::Button^  Servers;
	private: System::Windows::Forms::Button^  Settings;
	private: System::Windows::Forms::Panel^  panel1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Panel^  panel2;
	private: System::Windows::Forms::Label^  label2;








	protected: 


	protected: 





	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(Form1::typeid));
			this->splitContainer1 = (gcnew System::Windows::Forms::SplitContainer());
			this->Settings = (gcnew System::Windows::Forms::Button());
			this->Servers = (gcnew System::Windows::Forms::Button());
			this->panel2 = (gcnew System::Windows::Forms::Panel());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->panel1 = (gcnew System::Windows::Forms::Panel());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->splitContainer1->Panel1->SuspendLayout();
			this->splitContainer1->Panel2->SuspendLayout();
			this->splitContainer1->SuspendLayout();
			this->panel2->SuspendLayout();
			this->panel1->SuspendLayout();
			this->SuspendLayout();
			// 
			// splitContainer1
			// 
			this->splitContainer1->Dock = System::Windows::Forms::DockStyle::Fill;
			this->splitContainer1->Location = System::Drawing::Point(0, 0);
			this->splitContainer1->Name = L"splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this->splitContainer1->Panel1->Controls->Add(this->Settings);
			this->splitContainer1->Panel1->Controls->Add(this->Servers);
			// 
			// splitContainer1.Panel2
			// 
			this->splitContainer1->Panel2->Controls->Add(this->panel2);
			this->splitContainer1->Panel2->Controls->Add(this->panel1);
			this->splitContainer1->Size = System::Drawing::Size(601, 323);
			this->splitContainer1->SplitterDistance = 178;
			this->splitContainer1->TabIndex = 0;
			// 
			// Settings
			// 
			this->Settings->Location = System::Drawing::Point(12, 41);
			this->Settings->Name = L"Settings";
			this->Settings->Size = System::Drawing::Size(151, 23);
			this->Settings->TabIndex = 1;
			this->Settings->Text = L"Settings";
			this->Settings->UseVisualStyleBackColor = true;
			this->Settings->Click += gcnew System::EventHandler(this, &Form1::settings_click);
			// 
			// Servers
			// 
			this->Servers->Location = System::Drawing::Point(12, 12);
			this->Servers->Name = L"Servers";
			this->Servers->Size = System::Drawing::Size(151, 23);
			this->Servers->TabIndex = 0;
			this->Servers->Text = L"Servers";
			this->Servers->UseVisualStyleBackColor = true;
			this->Servers->Click += gcnew System::EventHandler(this, &Form1::servers_Click);
			// 
			// panel2
			// 
			this->panel2->Controls->Add(this->label2);
			this->panel2->Location = System::Drawing::Point(3, 3);
			this->panel2->Name = L"panel2";
			this->panel2->Size = System::Drawing::Size(416, 320);
			this->panel2->TabIndex = 1;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(3, 9);
			this->label2->Name = L"label2";
			this->label2->RightToLeft = System::Windows::Forms::RightToLeft::Yes;
			this->label2->Size = System::Drawing::Size(83, 13);
			this->label2->TabIndex = 0;
			this->label2->Text = L"Enter Path Here";
			this->label2->Click += gcnew System::EventHandler(this, &Form1::label2_Click);
			// 
			// panel1
			// 
			this->panel1->Controls->Add(this->label1);
			this->panel1->Location = System::Drawing::Point(0, 0);
			this->panel1->Name = L"panel1";
			this->panel1->Size = System::Drawing::Size(419, 323);
			this->panel1->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(89, 71);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"label1";
			// 
			// Form1
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(601, 323);
			this->Controls->Add(this->splitContainer1);
			this->Icon = (cli::safe_cast<System::Drawing::Icon^  >(resources->GetObject(L"$this.Icon")));
			this->Name = L"Form1";
			this->Text = L"ArcLaunch";
			this->splitContainer1->Panel1->ResumeLayout(false);
			this->splitContainer1->Panel2->ResumeLayout(false);
			this->splitContainer1->ResumeLayout(false);
			this->panel2->ResumeLayout(false);
			this->panel2->PerformLayout();
			this->panel1->ResumeLayout(false);
			this->panel1->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void servers_Click(System::Object^  sender, System::EventArgs^  e) {
				 hideallpanels();
				 panel1->Show();
			 }
	private: System::Void settings_click(System::Object^  sender, System::EventArgs^  e) {
				hideallpanels();
				panel2->Show();
			 }
private: System::Void label1_Click(System::Object^  sender, System::EventArgs^  e) {
		 }
private: System::Void hideallpanels() {
			  panel1->Hide();
			  panel2->Hide();
		 }
private: System::Void tabPage1_Click(System::Object^  sender, System::EventArgs^  e) {
		 }
private: System::Void label2_Click(System::Object^  sender, System::EventArgs^  e) {
		 }
};
}

