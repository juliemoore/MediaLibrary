namespace MediaLibrary
{


}

namespace MediaLibrary
{


    partial class MediaLibraryDataSet
    {
        partial class ConditionFinesViewDataTable
        {
        }

        partial class PatronsDataTable
        {
            public string FullName
            {
                get { return PatronFirstNameColumn + " " + PatronLastNameColumn; }
            }
        }
    }
}
