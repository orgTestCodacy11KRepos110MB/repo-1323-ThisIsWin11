﻿using System.Windows.Forms;
using ThisIsWin11.Lucent11.Assessment;

namespace ThisIsWin11.Lucent11
{
    internal class AssessmentNode : TreeNode
    {
        public AssessmentBase Assessment { get; }

        public AssessmentNode(AssessmentBase assessment)
        {
            Assessment = assessment;
            Text = Assessment.ID();
            ToolTipText = Assessment.Info();
            Checked = true;
        }
    }
}