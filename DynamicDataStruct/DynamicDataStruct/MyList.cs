using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDataStruct
{
    public class MyList
    {
        public ListItem firstItem;

        public int Length
        {
            get
            {
                int count = 0;

                ListItem currentItem = firstItem;

                while(currentItem != null )
                {
                    count++;
                    currentItem = currentItem.nextItem;

                }

                return count;
            }
            
        }


        public void AddItem(string rawData)
        {
            if (firstItem == null)
            {
                firstItem = new ListItem(rawData);
            }
            else
            {
                //find the end of the list and add a new item
                ListItem CurrentItem = firstItem;

                do
                {
                    if (CurrentItem.nextItem != null)
                    {

                        CurrentItem = CurrentItem.nextItem;
                    }
                } while (CurrentItem.nextItem != null);


                CurrentItem.nextItem = new ListItem(rawData);
            }
        }

    }

    public class ListItem
    {
        public string textData;
        public ListItem nextItem;


        public ListItem()  //creates null
        { }
        public ListItem(string _textData) //Constructor 
        {
            this.textData = _textData;
        }
    }
}
