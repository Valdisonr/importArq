using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Desab.Class
{
   
        class MaskedTextBoxCell : DataGridViewTextBoxCell
        {
            private string mask;
            private char promptChar;
            private DataGridViewTriState includePrompt;
            private DataGridViewTriState includeLiterals;
            private Type validatingType;

            //=------------------------------------------------------------------=
            // MaskedTextBoxCell
            //=------------------------------------------------------------------=
            /// <summary>
            ///   Initializes a new instance of this class.  Fortunately, there's
            ///   not much to do here except make sure that our base class is 
            ///   also initialized properly.
            /// </summary>
            /// 
            public MaskedTextBoxCell()
                : base()
            {
                this.mask = "";
                this.promptChar = '_';
                this.includePrompt = DataGridViewTriState.NotSet;
                this.includeLiterals = DataGridViewTriState.NotSet;
                this.validatingType = typeof(string);
            }

            public override void InitializeEditingControl(int rowIndex,
                                                          object initialFormattedValue,
                                                          DataGridViewCellStyle dataGridViewCellStyle)
            {
                MaskedTextBoxEditingControl mtbec;
                MaskedTextBoxColumn mtbcol;
                DataGridViewColumn dgvc;

                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                                              dataGridViewCellStyle);

                mtbec = DataGridView.EditingControl as MaskedTextBoxEditingControl;

                dgvc = this.OwningColumn;   // this.DataGridView.Columns[this.ColumnIndex];
                if (dgvc is MaskedTextBoxColumn)
                {
                    mtbcol = dgvc as MaskedTextBoxColumn;

                    //
                    // get the mask from this instance or the parent column.
                    //
                    if (string.IsNullOrEmpty(this.mask))
                    {
                        mtbec.Mask = mtbcol.Mask;
                    }
                    else
                    {
                        mtbec.Mask = this.mask;
                    }

                    //
                    // prompt char.
                    //
                    mtbec.PromptChar = this.PromptChar;

                    //
                    // IncludePrompt
                    //
                    if (this.includePrompt == DataGridViewTriState.NotSet)
                    {
                        //mtbec.IncludePrompt = mtbcol.IncludePrompt;
                    }
                    else
                    {
                        //mtbec.IncludePrompt = BoolFromTri(this.includePrompt);
                    }

                    //
                    // IncludeLiterals
                    //
                    if (this.includeLiterals == DataGridViewTriState.NotSet)
                    {
                        //mtbec.IncludeLiterals = mtbcol.IncludeLiterals;
                    }
                    else
                    {
                        //mtbec.IncludeLiterals = BoolFromTri(this.includeLiterals);
                    }

                    //
                    // Finally, the validating type ...
                    //
                    if (this.ValidatingType == null)
                    {
                        mtbec.ValidatingType = mtbcol.ValidatingType;
                    }
                    else
                    {
                        mtbec.ValidatingType = this.ValidatingType;
                    }

                    mtbec.Text = (string)this.Value;
                }
            }

            public override Type EditType
            {
                get 
                {
                    return typeof(MaskedTextBoxEditingControl);
                }
            }
            public virtual string Mask
            {
                get
                {
                    return this.mask;
                }
                set
                {
                    this.mask = value;
                }
            }

            //  The character to use for prompting for new input.
            // 
            public virtual char PromptChar
            {
                get
                {
                    return this.promptChar;
                }
                set
                {
                    this.promptChar = value;
                }
            }


            //  A boolean indicating whether to include prompt characters in
            //  the Text property's value.
            public virtual DataGridViewTriState IncludePrompt
            {
                get
                {
                    return this.includePrompt;
                }
                set
                {
                    this.includePrompt = value;
                }
            }

            //  A boolean value indicating whether to include literal characters
            //  in the Text property's output value.
            public virtual DataGridViewTriState IncludeLiterals
            {
                get
                {
                    return this.includeLiterals;
                }
                set
                {
                    this.includeLiterals = value;
                }
            }

            //  A Type object for the validating type.
            public virtual Type ValidatingType
            {
                get
                {
                    return this.validatingType;
                }
                set
                {
                    this.validatingType = value;
                }
            }

            //   Quick routine to convert from DataGridViewTriState to boolean.
            //   True goes to true while False and NotSet go to false.
            protected static bool BoolFromTri(DataGridViewTriState tri)
            {
                return (tri == DataGridViewTriState.True) ? true : false;
            }
        }
    
}
