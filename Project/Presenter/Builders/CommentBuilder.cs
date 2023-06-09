﻿/**************************************************************************
 *                                                                        *
 *  Description: Task Management Tool                    		          *
 *  Website Mihnea: https://github.com/Mihnea1711               	      *
 *  Website Robert: https://github.com/cioocan               	          *
 *  Copyright:   (c) 2023, Mihnea Bejinaru, Robert Ciocan                 *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System.Windows.Forms;

namespace Presenters
{
    public class CommentBuilder : ICommentBuilder
    {
        /// <summary>
        /// The final "product" of the builder.
        /// </summary>
        private DataGridViewRow commentRow;

        /// <summary>
        /// Method to retrieve the "product".
        /// </summary>
        /// <returns>Returns the actual data grid view row.</returns>
        public DataGridViewRow GetResult()
        {
            return commentRow;
        }
        /// <summary>
        /// Method to reset the data grid view row and to create a new one.
        /// </summary>
        public void Reset()
        {
            this.commentRow = new DataGridViewRow();
        }
        /// <summary>
        /// Method to set the comment description in the row.
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            DataGridViewCell descriptionCell = new DataGridViewTextBoxCell();
            descriptionCell.Value = description;

            //custom styling
            //..
            //

            this.commentRow.Cells.Add(descriptionCell);
        }
        /// <summary>
        /// Method to set the comment time reported in the row.
        /// </summary>
        /// <param name="timeReported"></param>
        public void SetTimeReported(int timeReported)
        {
            DataGridViewCell timeReportedCell = new DataGridViewTextBoxCell();
            timeReportedCell.Value = timeReported;

            //custom styling
            //..
            //

            this.commentRow.Cells.Add(timeReportedCell);
        }

        /// <summary>
        /// Method to set the title of the comment in the row.
        /// </summary>
        /// <param name="timeReported"></param>
        public void SetTitle(string title)
        {
            DataGridViewCell titleCell = new DataGridViewTextBoxCell();
            titleCell.Value = title;

            this.commentRow.Cells.Add(titleCell);
        } 
    }
}
