using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5___Edgar_Santana
{
    class Periodical : Item
    {
        private int issueNum;

        public Periodical() { }

        public Periodical(string title, int issueNum) : base(title)
        {
            this.issueNum = issueNum;
        }

        public int getIssueNum()
        {
            return issueNum;
        }

        public void setIssueNum(int issueNum)
        {
            this.issueNum = issueNum;
        }

        public override string getListing()
        {
            return "Periodical Title- " + getTitle() + "\nIssue #- " + issueNum;
        }
    }
}
