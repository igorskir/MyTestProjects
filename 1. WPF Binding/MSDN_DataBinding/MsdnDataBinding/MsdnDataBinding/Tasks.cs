using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MsdnDataBinding
{
    public enum TaskType
    {
        Home,
        Work
    }
    public class Task
    {
        public string TaskName { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public TaskType TaskType { get; set; }

    }
    public class TaskListDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null && item is Task)
            {
                Task taskitem = item as Task;

                return taskitem.Priority == 1
                    ? element.FindResource("importantTaskTemplate") as DataTemplate
                    : element.FindResource("myTaskTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
