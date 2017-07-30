using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseLocalViewAndEdit
{
    public partial class AddItemsToTable2 : Form
    {

        internal string _tablename;

        private Label lblTableName = new Label() { Location = new Point(10, 10), Size = new Size(150, 20), Visible = true };
        private Label lblID = new Label() { Location = new Point(10, 40), Size = new Size(50, 20), Visible = true };
        private TextBox boxID = new TextBox() { Enabled = false, Location = new Point(60, 40), Size = new Size(100, 20), Visible = true };
        private Label lblFam = new Label() { Text = "Фамилия", Location = new Point(10, 60), Size = new Size(90, 20), Visible = false };
        private TextBox boxFam = new TextBox() { Location = new Point(100, 60), Size = new Size(100, 20), Visible = false };
        private Label lblFir = new Label() { Text = "Имя", Location = new Point(10, 80), Size = new Size(90, 20), Visible = false };
        private TextBox boxFir = new TextBox() { Location = new Point(100, 80), Size = new Size(100, 20), Visible = false };
        private Label lblFath = new Label() { Text = "Отчество", Location = new Point(10, 100), Size = new Size(90, 20), Visible = false };
        private TextBox boxFath = new TextBox() { Location = new Point(100, 100), Size = new Size(100, 20), Visible = false };
        private Label lblDateOfB = new Label() { Text = "Дата рождения", Location = new Point(10, 120), Size = new Size(90, 20), Visible = false };
        private MaskedTextBox boxDateOfB = new MaskedTextBox("00/00/0000") { Location = new Point(100, 120), Size = new Size(100, 20), Visible = false };

        private Button btnCheckForDuplicate = new Button() { Text = "Проверить на наличие дубликатов", Location = new Point(10, 140), Size = new Size(150, 20), Visible = false };

        private Label lblGrade = new Label() { Text = "Курс", Location = new Point(10, 160), Size = new Size(40, 20), Visible = false };
        private TextBox boxGrade = new TextBox() { Width = 25, Location = new Point(50, 160), Size = new Size(50, 20), Visible = false };
        private Label lblGroup = new Label() { Text = "Группа", Location = new Point(110, 160), Size = new Size(40, 20), Visible = false };
        private TextBox boxGroup = new TextBox() { Width = 25, Location = new Point(150, 160), Size = new Size(50, 20), Visible = false };
        private Label lblPhoneNumber = new Label() { Text = "Номер телефона", Location = new Point(10, 180), Size = new Size(90, 20), Visible = false };
        private MaskedTextBox boxPhoneNumber = new MaskedTextBox("(999) 000-00-00") { Location = new Point(100, 180), Size = new Size(100, 20), Visible = false };
        private Label lblTypeOfEdu = new Label() { Text = "Форма обучения", Location = new Point(10, 200), Size = new Size(90, 20), Visible = false };
        private ComboBox boxTypeOfEdu = new ComboBox() { Items = { "бюджетна", "контрактна" }, SelectedIndex = 0, Location = new Point(100, 200), Size = new Size(100, 20), Visible = false };
        private Label lblOrderOfAcc = new Label() { Text = "Приказ о зачислении", Location = new Point(10, 220), Size = new Size(90, 20), Visible = false };
        private MaskedTextBox boxOrderOfAcc = new MaskedTextBox("Наказ №9999-L від 90/90/0000 р.") { Location = new Point(100, 220), Size = new Size(100, 20), Visible = false };

        private Label lblEMail = new Label() { Text = "Электронный адрес", Location = new Point(10, 240), Size = new Size(90, 20), Visible = false };
        private TextBox boxEMail = new TextBox() { Location = new Point(100, 240), Size = new Size(100, 20), Visible = false };
        private Label lblRelation = new Label() { Text = "Связь с университетом", Location = new Point(10, 260), Size = new Size(90, 20), Visible = false };
        private TextBox boxRelation = new TextBox() { Location = new Point(100, 260), Size = new Size(100, 20), Visible = false };

        private Label lblSpcID = new Label() { Text = "ИН студента", Location = new Point(210, 10), Size = new Size(65, 20), Visible = false };
        private TextBox boxSpcID = new TextBox() { Location = new Point(275, 10), Size = new Size(75, 20), Visible = false };
        private Button btnFindPers = new Button() { Text = "Найти ИН", Location = new Point(350, 10), Size = new Size(50, 20), Visible = false };
        private Label lblDateOfRequest = new Label() { Text = "Дата запроса", Location = new Point(210, 30), Size = new Size(90, 20), Visible = false };
        private MaskedTextBox boxDateOfRequest = new MaskedTextBox("00/00/0000") { Location = new Point(300, 30), Size = new Size(100, 20), Visible = false };
        private Label lblNumberOfMissedClasses = new Label() { Text = "Количество пропущенных занятий", Location = new Point(210, 50), Size = new Size(90, 20), Visible = false };
        private TextBox boxNumberOfMissedClasses = new TextBox() { Location = new Point(300, 50), Size = new Size(100, 20), Visible = false };
        private Label lblListOfMissedClasses = new Label() { Text = "Даты пропущенных занятий", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };
        private TextBox boxListOfMissedClasses = new TextBox() { Location = new Point(300, 70), Size = new Size(100, 20), Visible = false };
        private Label lblMissedDepartment = new Label() { Text = "Пропущенная кафедра", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };
        private TextBox boxMissedDepartment = new TextBox() { Location = new Point(300, 70), Size = new Size(100, 20), Visible = false };
        private Label lblPermissionType = new Label() { Text = "Вид разрешения", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };
        private TextBox boxPermissionType = new TextBox() { Location = new Point(300, 70), Size = new Size(100, 20), Visible = false };
        private Label lblExplanation = new Label() { Text = "Объяснение", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };
        private TextBox boxExplanation = new TextBox() { Location = new Point(300, 70), Size = new Size(100, 20), Visible = false };
        private Label lblValidTill = new Label() { Text = "Пропущенная кафедра", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };
        private TextBox boxValidTill = new TextBox() { Location = new Point(300, 70), Size = new Size(100, 20), Visible = false };

        private Label lblArrived = new Label() { Text = "", Location = new Point(210, 70), Size = new Size(90, 20), Visible = false };

        private CheckBox chkArrived = new CheckBox() { Text = "Прибыл", Location = new Point(210, 90), Size = new Size(65, 20), Visible = false };
        private CheckBox chkAllowed = new CheckBox() { Text = "Разрешено", Location = new Point(275, 90), Size = new Size(75, 20), Visible = false };
        private CheckBox chkReceived = new CheckBox() { Text = "Вручено", Location = new Point(350, 90), Size = new Size(50, 20), Visible = false };

        private Label lblRequestingOrganization = new Label() { Text = "Запрашивающая организация", Location = new Point(210, 110), Size = new Size(90, 20), Visible = false };
        private TextBox boxRequestingOrganization = new TextBox() { Location = new Point(300, 110), Size = new Size(100, 20), Visible = false };

        private CheckBox chkStudent = new CheckBox() { Text = "Студент?", Location = new Point(210, 130), Size = new Size(90, 20), Visible = false };

        private Label lblDateOfReceipt = new Label() { Text = "Дата приглашения", Location = new Point(210, 150), Size = new Size(90, 20), Visible = false };
        private MaskedTextBox boxDateOfReceipt = new MaskedTextBox("00/00/0000 00:00") { Location = new Point(300, 150), Size = new Size(100, 20), Visible = false, Enabled = false };
        private Label lblReason = new Label() { Text = "Причина обращения", Location = new Point(210, 170), Size = new Size(90, 20), Visible = false };
        private TextBox boxReason = new TextBox() { Location = new Point(300, 170), Size = new Size(100, 20), Visible = false };

        private Button btnAcceptRecord = new Button() { Text = "Сохранить", Location = new Point(10, 320), Size = new Size(90, 20), Visible = false };
        private Button btnCancelRecord = new Button() { Text = "Отмена", Location = new Point(100, 320), Size = new Size(190, 20), Visible = false };


        public AddItemsToTable2(string tablename)
        {
            _tablename = tablename;
            InitializeComponent();
        }

        private void AddItemsToTable2_Load_1(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new System.Drawing.Size(330, 410);
            this.Text = "Добавить запись";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            switch (_tablename)
            {
                case "Students":
                    #region StudentsForm

                    lblTableName.Text = _tablename;
                    lblTableName.Location = new Point(10, 10);
                    lblTableName.Size = new Size(150, 20);
                    lblTableName.Visible = true;
                    this.Controls.Add(lblTableName);
                    //
                    lblID.Text = "ИН студента";
                    lblID.Location = new Point(10, 40);
                    lblID.Size = new Size(50, 20);
                    lblID.Visible = true;
                    this.Controls.Add(lblID);
                    boxID.Location = new Point(60, 40);
                    boxID.Size = new Size(100, 20);
                    boxID.Visible = true;
                    this.Controls.Add(boxID);
                    //
                    lblFam.Location = new Point(10, 60);
                    lblFam.Size = new Size(90, 20);
                    lblFam.Visible = true;
                    this.Controls.Add(lblFam);
                    boxFam.Location = new Point(100, 60);
                    boxFam.Size = new Size(100, 20);
                    boxFam.Visible = true;
                    this.Controls.Add(boxFam);
                    //
                    lblFir.Location = new Point(10, 80);
                    lblFir.Size = new Size(90, 20);
                    lblFir.Visible = true;
                    this.Controls.Add(lblFir);
                    boxFir.Location = new Point(100, 80);
                    boxFir.Size = new Size(100, 20);
                    boxFir.Visible = true;
                    this.Controls.Add(boxFir);
                    //
                    lblFath.Location = new Point(10, 100);
                    lblFath.Size = new Size(90, 20);
                    lblFath.Visible = true;
                    this.Controls.Add(lblFath);
                    boxFath.Location = new Point(100, 100);
                    boxFath.Size = new Size(100, 20);
                    boxFath.Visible = true;
                    this.Controls.Add(boxFath);
                    //
                    lblDateOfB.Location = new Point(10, 120);
                    lblDateOfB.Size = new Size(90, 20);
                    lblDateOfB.Visible = true;
                    this.Controls.Add(lblDateOfB);
                    boxDateOfB.Location = new Point(100, 120);
                    boxDateOfB.Size = new Size(100, 20);
                    boxDateOfB.Visible = true;
                    this.Controls.Add(boxDateOfB);

                    //
                    btnCheckForDuplicate.Location = new Point(10, 140);
                    btnCheckForDuplicate.Size = new Size(150, 20);
                    btnCheckForDuplicate.Visible = true;
                    btnCheckForDuplicate.Click += new EventHandler(btnCheckForDuplicate_Click);
                    this.Controls.Add(btnCheckForDuplicate);
                    //
                    lblGrade.Location = new Point(10, 160);
                    lblGrade.Size = new Size(40, 20);
                    lblGrade.Visible = true;
                    this.Controls.Add(lblGrade);
                    boxGrade.Location = new Point(50, 160);
                    boxGrade.Size = new Size(50, 20);
                    boxGrade.Visible = true;
                    this.Controls.Add(boxGrade);
                    //
                    lblGroup.Location = new Point(110, 160);
                    lblGroup.Size = new Size(40, 20);
                    lblGroup.Visible = true;
                    this.Controls.Add(lblGroup);
                    boxGroup.Location = new Point(150, 160);
                    boxGroup.Size = new Size(50, 20);
                    boxGroup.Visible = true;
                    this.Controls.Add(boxGroup);
                    //
                    lblGroup.Location = new Point(110, 160);
                    lblGroup.Size = new Size(40, 20);
                    lblGroup.Visible = true;
                    this.Controls.Add(lblGroup);
                    boxGroup.Location = new Point(150, 160);
                    boxGroup.Size = new Size(50, 20);
                    boxGroup.Visible = true;
                    this.Controls.Add(boxGroup);
                    //
                    lblPhoneNumber.Location = new Point(10, 180);
                    lblPhoneNumber.Size = new Size(90, 20);
                    lblPhoneNumber.Visible = true;
                    this.Controls.Add(lblPhoneNumber);
                    boxPhoneNumber.Location = new Point(100, 180);
                    boxPhoneNumber.Size = new Size(100, 20);
                    boxPhoneNumber.Visible = true;
                    this.Controls.Add(boxPhoneNumber);
                    //
                    lblTypeOfEdu.Location = new Point(10, 200);
                    lblTypeOfEdu.Size = new Size(90, 20);
                    lblTypeOfEdu.Visible = true;
                    this.Controls.Add(lblTypeOfEdu);
                    boxTypeOfEdu.Location = new Point(100, 200);
                    boxTypeOfEdu.Size = new Size(100, 20);
                    boxTypeOfEdu.Visible = true;
                    this.Controls.Add(boxTypeOfEdu);
                    //
                    lblOrderOfAcc.Location = new Point(10, 220);
                    lblOrderOfAcc.Size = new Size(90, 20);
                    lblOrderOfAcc.Visible = true;
                    this.Controls.Add(lblOrderOfAcc);
                    boxOrderOfAcc.Location = new Point(100, 220);
                    boxOrderOfAcc.Size = new Size(100, 20);
                    boxOrderOfAcc.Visible = true;
                    this.Controls.Add(boxOrderOfAcc);
                    //
                    btnAcceptRecord.Location = new Point(10, 260);
                    btnAcceptRecord.Size = new Size(100, 20);
                    btnAcceptRecord.Visible = true;
                    btnAcceptRecord.Click += new EventHandler(btnAcceptRecord_Click);
                    this.Controls.Add(btnAcceptRecord);
                    btnCancelRecord.Location = new Point(110, 260);
                    btnCancelRecord.Size = new Size(90, 20);
                    btnCancelRecord.Visible = true;
                    btnCancelRecord.Click += new EventHandler(btnCancelRecord_Click);
                    this.Controls.Add(btnCancelRecord);
                    #endregion
                    break;

                case "GuestsOfAdministration":
                    #region GuestsOfAdministration

                    lblTableName.Text = _tablename;
                    lblTableName.Location = new Point(10, 10);
                    lblTableName.Size = new Size(150, 20);
                    lblTableName.Visible = true;
                    this.Controls.Add(lblTableName);
                    //
                    lblID.Text = "ИН гостя";
                    lblID.Location = new Point(10, 40);
                    lblID.Size = new Size(50, 20);
                    lblID.Visible = true;
                    this.Controls.Add(lblID);
                    boxID.Location = new Point(60, 40);
                    boxID.Size = new Size(100, 20);
                    boxID.Visible = true;
                    this.Controls.Add(boxID);
                    //
                    lblFam.Location = new Point(10, 60);
                    lblFam.Size = new Size(90, 20);
                    lblFam.Visible = true;
                    this.Controls.Add(lblFam);
                    boxFam.Location = new Point(100, 60);
                    boxFam.Size = new Size(100, 20);
                    boxFam.Visible = true;
                    this.Controls.Add(boxFam);
                    //
                    lblFir.Location = new Point(10, 80);
                    lblFir.Size = new Size(90, 20);
                    lblFir.Visible = true;
                    this.Controls.Add(lblFir);
                    boxFir.Location = new Point(100, 80);
                    boxFir.Size = new Size(100, 20);
                    boxFir.Visible = true;
                    this.Controls.Add(boxFir);
                    //
                    lblFath.Location = new Point(10, 100);
                    lblFath.Size = new Size(90, 20);
                    lblFath.Visible = true;
                    this.Controls.Add(lblFath);
                    boxFath.Location = new Point(100, 100);
                    boxFath.Size = new Size(100, 20);
                    boxFath.Visible = true;
                    this.Controls.Add(boxFath);
                    //
                    lblDateOfB.Location = new Point(10, 120);
                    lblDateOfB.Size = new Size(90, 20);
                    lblDateOfB.Visible = true;
                    this.Controls.Add(lblDateOfB);
                    boxDateOfB.Location = new Point(100, 120);
                    boxDateOfB.Size = new Size(100, 20);
                    boxDateOfB.Visible = true;
                    this.Controls.Add(boxDateOfB);
                    //
                    btnCheckForDuplicate.Location = new Point(10, 140);
                    btnCheckForDuplicate.Size = new Size(150, 20);
                    btnCheckForDuplicate.Visible = true;
                    this.Controls.Add(btnCheckForDuplicate);
                    //
                    lblEMail.Location = new Point(10, 160);
                    lblEMail.Size = new Size(90, 20);
                    lblEMail.Visible = true;
                    this.Controls.Add(lblEMail);
                    boxEMail.Location = new Point(100, 160);
                    boxEMail.Size = new Size(100, 20);
                    boxEMail.Visible = true;
                    this.Controls.Add(boxEMail);
                    //
                    lblPhoneNumber.Location = new Point(10, 180);
                    lblPhoneNumber.Size = new Size(90, 20);
                    lblPhoneNumber.Visible = true;
                    this.Controls.Add(lblPhoneNumber);
                    boxPhoneNumber.Location = new Point(100, 180);
                    boxPhoneNumber.Size = new Size(100, 20);
                    boxPhoneNumber.Visible = true;
                    this.Controls.Add(boxPhoneNumber);
                    //
                    lblRelation.Location = new Point(10, 200);
                    lblRelation.Size = new Size(90, 20);
                    lblRelation.Visible = true;
                    this.Controls.Add(lblRelation);
                    boxRelation.Location = new Point(100, 200);
                    boxRelation.Size = new Size(100, 20);
                    boxRelation.Visible = true;
                    this.Controls.Add(boxRelation);
                    //
                    btnAcceptRecord.Location = new Point(10, 260);
                    btnAcceptRecord.Size = new Size(100, 20);
                    btnAcceptRecord.Visible = true;
                    this.Controls.Add(btnAcceptRecord);
                    btnCancelRecord.Location = new Point(110, 260);
                    btnCancelRecord.Size = new Size(90, 20);
                    btnCancelRecord.Visible = true;
                    this.Controls.Add(btnCancelRecord);
                    #endregion
                    break;

                case "RequestForPermission":
                    #region RequestForPermission

                    lblTableName.Text = _tablename;
                    lblTableName.Location = new Point(10, 10);
                    lblTableName.Size = new Size(150, 20);
                    lblTableName.Visible = true;
                    this.Controls.Add(lblTableName);
                    //
                    lblSpcID.Text = "ИН студента";
                    lblSpcID.Location = new Point(10, 40);
                    lblSpcID.Size = new Size(50, 20);
                    lblSpcID.Visible = true;
                    this.Controls.Add(lblSpcID);
                    boxSpcID.Location = new Point(60, 40);
                    boxSpcID.Size = new Size(90, 20);
                    boxSpcID.Visible = true;
                    this.Controls.Add(boxSpcID);
                    btnFindPers.Location = new Point(150, 40);
                    btnFindPers.Size = new Size(50, 20);
                    btnFindPers.Visible = true;
                    this.Controls.Add(btnFindPers);
                    //
                    lblDateOfRequest.Location = new Point(10, 60);
                    lblDateOfRequest.Size = new Size(90, 20);
                    lblDateOfRequest.Visible = true;
                    this.Controls.Add(lblDateOfRequest);
                    boxDateOfRequest.Location = new Point(100, 60);
                    boxDateOfRequest.Size = new Size(100, 20);
                    boxDateOfRequest.Visible = true;
                    this.Controls.Add(boxDateOfRequest);
                    //
                    lblNumberOfMissedClasses.Location = new Point(10, 80);
                    lblNumberOfMissedClasses.Size = new Size(90, 20);
                    lblNumberOfMissedClasses.Visible = true;
                    this.Controls.Add(lblNumberOfMissedClasses);
                    boxNumberOfMissedClasses.Location = new Point(100, 80);
                    boxNumberOfMissedClasses.Size = new Size(100, 20);
                    boxNumberOfMissedClasses.Visible = true;
                    this.Controls.Add(boxNumberOfMissedClasses);
                    //
                    lblListOfMissedClasses.Location = new Point(10, 100);
                    lblListOfMissedClasses.Size = new Size(90, 20);
                    lblListOfMissedClasses.Visible = true;
                    this.Controls.Add(lblListOfMissedClasses);
                    boxListOfMissedClasses.Location = new Point(100, 100);
                    boxListOfMissedClasses.Size = new Size(100, 20);
                    boxListOfMissedClasses.Visible = true;
                    this.Controls.Add(boxListOfMissedClasses);
                    //
                    lblMissedDepartment.Location = new Point(10, 120);
                    lblMissedDepartment.Size = new Size(90, 20);
                    lblMissedDepartment.Visible = true;
                    this.Controls.Add(lblMissedDepartment);
                    boxMissedDepartment.Location = new Point(100, 120);
                    boxMissedDepartment.Size = new Size(100, 20);
                    boxMissedDepartment.Visible = true;
                    this.Controls.Add(boxMissedDepartment);
                    //
                    lblPermissionType.Location = new Point(10, 140);
                    lblPermissionType.Size = new Size(90, 20);
                    lblPermissionType.Visible = true;
                    this.Controls.Add(lblPermissionType);
                    boxPermissionType.Location = new Point(100, 140);
                    boxPermissionType.Size = new Size(100, 20);
                    boxPermissionType.Visible = true;
                    this.Controls.Add(boxPermissionType);
                    //
                    lblExplanation.Location = new Point(10, 160);
                    lblExplanation.Size = new Size(90, 20);
                    lblExplanation.Visible = true;
                    this.Controls.Add(lblExplanation);
                    boxExplanation.Location = new Point(100, 160);
                    boxExplanation.Size = new Size(100, 20);
                    boxExplanation.Visible = true;
                    this.Controls.Add(boxExplanation);
                    //
                    lblValidTill.Location = new Point(10, 180);
                    lblValidTill.Size = new Size(90, 20);
                    lblValidTill.Visible = true;
                    this.Controls.Add(lblValidTill);
                    boxValidTill.Location = new Point(100, 180);
                    boxValidTill.Size = new Size(100, 20);
                    boxValidTill.Visible = true;
                    this.Controls.Add(boxValidTill);
                    //
                    chkArrived.Location = new Point(10, 200);
                    chkArrived.Size = new Size(50, 20);
                    chkArrived.Visible = true;
                    this.Controls.Add(chkArrived);
                    chkAllowed.Location = new Point(60, 200);
                    chkAllowed.Size = new Size(60, 20);
                    chkAllowed.Visible = true;
                    this.Controls.Add(chkAllowed);
                    chkReceived.Location = new Point(120, 200);
                    chkReceived.Size = new Size(60, 20);
                    chkReceived.Visible = true;
                    this.Controls.Add(chkReceived);
                    //
                    btnAcceptRecord.Location = new Point(10, 260);
                    btnAcceptRecord.Size = new Size(100, 20);
                    btnAcceptRecord.Visible = true;
                    this.Controls.Add(btnAcceptRecord);
                    btnCancelRecord.Location = new Point(110, 260);
                    btnCancelRecord.Size = new Size(90, 20);
                    btnCancelRecord.Visible = true;
                    this.Controls.Add(btnCancelRecord);
                    #endregion
                    break;

                case "RequestForCertificates":
                    #region RequestForCertificates

                    lblTableName.Text = _tablename;
                    lblTableName.Location = new Point(10, 10);
                    lblTableName.Size = new Size(150, 20);
                    lblTableName.Visible = true;
                    this.Controls.Add(lblTableName);
                    //
                    lblSpcID.Text = "ИН студента";
                    lblSpcID.Location = new Point(10, 40);
                    lblSpcID.Size = new Size(50, 20);
                    lblSpcID.Visible = true;
                    this.Controls.Add(lblSpcID);
                    boxSpcID.Location = new Point(60, 40);
                    boxSpcID.Size = new Size(90, 20);
                    boxSpcID.Visible = true;
                    this.Controls.Add(boxSpcID);
                    btnFindPers.Location = new Point(150, 40);
                    btnFindPers.Size = new Size(50, 20);
                    btnFindPers.Visible = true;
                    this.Controls.Add(btnFindPers);
                    //
                    lblDateOfRequest.Location = new Point(10, 60);
                    lblDateOfRequest.Size = new Size(90, 20);
                    lblDateOfRequest.Visible = true;
                    this.Controls.Add(lblDateOfRequest);
                    boxDateOfRequest.Location = new Point(100, 60);
                    boxDateOfRequest.Size = new Size(100, 20);
                    boxDateOfRequest.Visible = true;
                    this.Controls.Add(boxDateOfRequest);
                    //
                    lblRequestingOrganization.Location = new Point(10, 180);
                    lblRequestingOrganization.Size = new Size(90, 20);
                    lblRequestingOrganization.Visible = true;
                    this.Controls.Add(lblRequestingOrganization);
                    boxRequestingOrganization.Location = new Point(100, 180);
                    boxRequestingOrganization.Size = new Size(100, 20);
                    boxRequestingOrganization.Visible = true;
                    this.Controls.Add(boxRequestingOrganization);
                    //
                    chkArrived.Location = new Point(10, 200);
                    chkArrived.Size = new Size(50, 20);
                    chkArrived.Visible = true;
                    this.Controls.Add(chkArrived);
                    chkAllowed.Location = new Point(60, 200);
                    chkAllowed.Size = new Size(60, 20);
                    chkAllowed.Visible = true;
                    this.Controls.Add(chkAllowed);
                    chkReceived.Location = new Point(120, 200);
                    chkReceived.Size = new Size(60, 20);
                    chkReceived.Visible = true;
                    this.Controls.Add(chkReceived);
                    //
                    btnAcceptRecord.Location = new Point(10, 260);
                    btnAcceptRecord.Size = new Size(100, 20);
                    btnAcceptRecord.Visible = true;
                    this.Controls.Add(btnAcceptRecord);
                    btnCancelRecord.Location = new Point(110, 260);
                    btnCancelRecord.Size = new Size(90, 20);
                    btnCancelRecord.Visible = true;
                    this.Controls.Add(btnCancelRecord);
                    #endregion
                    break;

                case "DeansRecord":
                    #region DeansRecord

                    lblTableName.Text = _tablename;
                    lblTableName.Location = new Point(10, 10);
                    lblTableName.Size = new Size(150, 20);
                    lblTableName.Visible = true;
                    this.Controls.Add(lblTableName);
                    //
                    lblSpcID.Text = "ИН гостя";
                    lblSpcID.Location = new Point(10, 40);
                    lblSpcID.Size = new Size(50, 20);
                    lblSpcID.Visible = true;
                    this.Controls.Add(lblSpcID);
                    boxSpcID.Location = new Point(60, 40);
                    boxSpcID.Size = new Size(60, 20);
                    boxSpcID.Visible = true;
                    this.Controls.Add(boxSpcID);
                    chkStudent.Location = new Point(120, 40);
                    chkStudent.Size = new Size(60, 20);
                    chkStudent.Visible = true;
                    this.Controls.Add(chkStudent);
                    btnFindPers.Location = new Point(180, 40);
                    btnFindPers.Size = new Size(50, 20);
                    btnFindPers.Visible = true;
                    this.Controls.Add(btnFindPers);
                    //
                    lblDateOfRequest.Location = new Point(10, 60);
                    lblDateOfRequest.Size = new Size(90, 20);
                    lblDateOfRequest.Visible = true;
                    this.Controls.Add(lblDateOfRequest);
                    boxDateOfRequest.Location = new Point(100, 60);
                    boxDateOfRequest.Size = new Size(100, 20);
                    boxDateOfRequest.Visible = true;
                    this.Controls.Add(boxDateOfRequest);
                    //
                    lblDateOfReceipt.Location = new Point(10, 80);
                    lblDateOfReceipt.Size = new Size(90, 20);
                    lblDateOfReceipt.Visible = true;
                    this.Controls.Add(lblDateOfReceipt);
                    boxDateOfReceipt.Location = new Point(100, 80);
                    boxDateOfReceipt.Size = new Size(100, 20);
                    boxDateOfReceipt.Visible = true;
                    this.Controls.Add(boxDateOfReceipt);
                    //
                    lblReason.Location = new Point(10, 80);
                    lblReason.Size = new Size(90, 20);
                    lblReason.Visible = true;
                    this.Controls.Add(lblReason);
                    boxReason.Location = new Point(100, 80);
                    boxReason.Size = new Size(100, 20);
                    boxReason.Visible = true;
                    this.Controls.Add(boxReason);
                    //
                    chkArrived.Location = new Point(10, 200);
                    chkArrived.Size = new Size(50, 20);
                    chkArrived.Visible = true;
                    this.Controls.Add(chkArrived);
                    chkAllowed.Location = new Point(60, 200);
                    chkAllowed.Size = new Size(60, 20);
                    chkAllowed.Visible = true;
                    this.Controls.Add(chkAllowed);
                    //
                    btnAcceptRecord.Location = new Point(10, 260);
                    btnAcceptRecord.Size = new Size(100, 20);
                    btnAcceptRecord.Visible = true;
                    this.Controls.Add(btnAcceptRecord);
                    btnCancelRecord.Location = new Point(110, 260);
                    btnCancelRecord.Size = new Size(90, 20);
                    btnCancelRecord.Visible = true;
                    this.Controls.Add(btnCancelRecord);
                    #endregion
                    break;
            }
        }

        private void btnCancelRecord_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAcceptRecord_Click(object sender, EventArgs e)
        {
            //1. Get all variables;
            //2. Add record to db;
            this.Dispose();
            this.DialogResult = DialogResult.OK;
        }

        private void btnCheckForDuplicate_Click(object sender, EventArgs e)
        {
            //0. Collect all variables for sending
            //1. Initiate request to DB
            //2. If no dupl == assign ID, else == modal window
            //3. 
        }

        private void AddItemsToTable2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
