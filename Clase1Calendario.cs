/*Carrasco, Nathan
Herrera, Francisco
Wu, Ivan*/

using System;
using System.Windows.Forms;

namespace Lab4v2
{
    public class CalendarioDataGridView : DataGridViewTextBoxCell
    {
        public CalendarioDataGridView() : base()
        {
            this.Style.Format = "d"; // Short date format
        }

        public override void InitializeEditingControl(int RowIndex, object valorInicialFormateado, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(RowIndex, valorInicialFormateado, dataGridViewCellStyle);
            CalendarEditingControl ctl = DataGridView.EditingControl as CalendarEditingControl;

            // Usar el valor de la celda como el valor actual en DateTimePicker.
            if (this.Value == null)
            {
                ctl.Value = (DateTime)this.DefaultNewRowValue;
            }
            else
            {
                ctl.Value = (DateTime)this.Value;
            }
        }

        public override Type EditType
        {
            get { return typeof(CalendarEditingControl); }
        }

        public override Type ValueType
        {
            get { return typeof(DateTime); }
        }

        public override object DefaultNewRowValue
        {
            get { return DateTime.Now; }
        }
    }

    public class columnaCalendario : DataGridViewColumn
    {
        public columnaCalendario() : base(new CalendarioDataGridView())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get { return base.CellTemplate; }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarioDataGridView)))
                {
                    throw new InvalidCastException("Must be a CalendarioDataGridView");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            // Set the date range (no earlier than today, no later than 10 years from now)
            this.MinDate = DateTime.Today;
            this.MaxDate = DateTime.Today.AddYears(1);
            this.Format = DateTimePickerFormat.Short;
        }

        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToShortDateString();
            }
            set
            {
                if (value is String)
                {
                    DateTime enteredDate;
                    if (DateTime.TryParse((String)value, out enteredDate))
                    {
                        // Ensure that the entered date is within the allowed range.
                        if (enteredDate < this.MinDate)
                        {
                            this.Value = this.MinDate;
                        }
                        else if (enteredDate > this.MaxDate)
                        {
                            this.Value = this.MaxDate;
                        }
                        else
                        {
                            this.Value = enteredDate;
                        }
                    }
                    else
                    {
                        // If the entered value is not a valid date, reset to the MinDate.
                        this.Value = this.MinDate;
                    }
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get { return rowIndex; }
            set { rowIndex = value; }
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        { 
        }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public DataGridView EditingControlDataGridView
        {
            get { return dataGridView; }
            set { dataGridView = value; }
        }

        public bool EditingControlValueChanged
        {
            get { return valueChanged; }
            set { valueChanged = value; }
        }

        public Cursor EditingPanelCursor
        {
            get { return base.Cursor; }
        }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
