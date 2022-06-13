using System.Linq;
using System.Windows.Forms;

namespace PILab8
{
    public partial class CarsForm : Form
    {
        private TreeNode _activeNode;
        private TreeNode ActiveNode 
        {
            get => _activeNode;
            set 
            {
                _activeNode = value;
                RemoveButton.Enabled = _activeNode != null;
            }
        }
        private readonly CarsCollection Collection = new CarsCollection();
        public CarsForm()
        {
            InitializeComponent();
            InitializeDriveComboBox();
            InitializeGearBoxComboBox();
            InitializeHierarchyTree();
            ActiveNode = null;
        }

        private void InitializeHierarchyTree()
        {
            HierarchyTree.Nodes.Clear();

            foreach (var groupByBrand in Collection.Cars.GroupBy(c => c.Brand))
            {
                TreeNode brandNode = new TreeNode(groupByBrand.Key);

                foreach (var modelGroup in groupByBrand.GroupBy(g => g.Model))
                {
                    TreeNode modelNode = brandNode.Nodes.Add(modelGroup.Key);
                    var gearGroup = modelGroup.GroupBy(c => new
                    {
                        c.Transmittion.GearBox.Kind,
                        c.Transmittion.GearBox.Count,
                    });

                    foreach (var gearBox in gearGroup)
                    {
                        modelNode.Nodes.Add($"{gearBox.Key.Kind} {gearBox.Key.Count}");
                    }
                }

                HierarchyTree.Nodes.Add(brandNode);
            }
        }

        private void InitializeGearBoxComboBox()
        {
            GearBoxComboBox.Items.Clear();

            foreach (var gearBox in CarsPresets.GearBoxes.Keys)
            {
                GearBoxComboBox.Items.Add(gearBox);
            }

            GearBoxComboBox.SelectedIndex = 0;
        }

        private void InitializeDriveComboBox()
        {
            DriveComboBox.Items.Clear();

            foreach (var drive in WheelsDriven.Keys)
            {
                DriveComboBox.Items.Add(drive);
            }

            DriveComboBox.SelectedIndex = 0;
        }

        private Car GetFormValues()
        {
            GearBox gearBox = CarsPresets.GearBoxes[GearBoxComboBox.Text];
         
            return new Car()
            {
                Brand = BrandTextBox.Text,
                Model = ModelTextBox.Text,
                Transmittion = new Transmission(gearBox),
            };
        }

        private void ClearForm()
        {
            BrandTextBox.Text = "";
            ModelTextBox.Text = "";
        }

        private void OnNodeClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ActiveNode = e.Node;
        }

        private void OnRemove(object sender, System.EventArgs e)
        {
            if (ActiveNode != null)
            {
                ActiveNode.Remove();
                ActiveNode = null;
            }
        }

        private void OnAdd(object sender, System.EventArgs e)
        {
            Collection.Cars.Add(GetFormValues());
            ClearForm();
            InitializeHierarchyTree();
        }
    }
}
