using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace TeelSys.Settings
{
    //Set this 'Settings' class as the root node of any XML file its serialized to.
    //[XmlRootAttribute("DbSettings", Namespace = "DBBackupMonitor", IsNullable = false)]
    [Serializable]
    public class WindowSettings
    {/*** Fields ***/
        #region
        [OptionalField(VersionAdded = 1)]
        private Point m_Location;
        #endregion

        /*** Properties ***/
        #region
        public int Height { get; set; }

        public int Width { get; set; }

        public Point Location
        {
            get
            {
                Rectangle checkArea = new Rectangle(m_Location.X, m_Location.Y, 100, 100);
                if (!RectangleIsOnScreen(checkArea))
                {
                    m_Location.X = 10;
                    m_Location.Y = 10;
                }

                return m_Location;
            }
            set { m_Location = value; }
        }

        public int TabIndex { get; set; }
        #endregion

        /*** Constructor ***/
        #region
        public WindowSettings()
        {
            Height = 600;
            Width = 800;
            m_Location = new Point(10, 10);
            TabIndex = 0;
        }
        #endregion

        /*** Public Methods ***/
        #region
        public bool FormIsOnScreen(Form formToCheck)
        {
            Rectangle rectangle = new Rectangle(formToCheck.Left, formToCheck.Top, formToCheck.Width, formToCheck.Height);

            return RectangleIsOnScreen(rectangle);
        }

        public bool PointIsOnScreen(Point pointToCheck)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                if (screen.WorkingArea.Contains(pointToCheck))
                {
                    return true;
                }
            }

            return false;
        }

        public bool RectangleIsOnScreen(Rectangle rectangleToCheck)
        {
            Screen[] screens = Screen.AllScreens;
            foreach (Screen screen in screens)
            {
                screen.WorkingArea.Intersect(rectangleToCheck);
                if (screen.WorkingArea.Contains(rectangleToCheck))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
