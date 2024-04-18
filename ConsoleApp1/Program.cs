public class Solution
{
    public class TreeNode
    {
        public int value;
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public TreeNode(int val)
        {
            value = val;
            right = null;
            left = null;
        }

    }
    public TreeNode root;//корень дерева
    public Solution(int value)
    {
        root = new TreeNode(value);//изначально даем корневое значение
    }
    public void Add(int value)
    {
        if (root == null)//если корня нет
        {
            root = new TreeNode(value);//делаем текущий элемент,как корневой
            return;
        }
        TreeNode current = root;//текущий=корневой
        bool added = false;
        //пробежка по дереву
        do
        {
            if (value >= current.value)//идем вправо,т.к.новый элемент больше текущего
            {
                if (current.right == null)//если справо пусто
                {
                    current.right = new TreeNode(value);//добавляем элемент направо
                    added = true;
                }
                else
                {
                    current = current.right;//приравнивываем текущий элемент к текущему элементу справа
                }
            }
            if (value <= current.value)//идем на лево,т.к. новый элемент меньше текущего 
            {
                if (current.left == null)//если слева пусто
                {
                    current.left = new TreeNode(value);//добавляем элемент на лево
                    added = true;
                }
                else
                {
                    current = current.left;//приравнивываем текущий элемент к текущему элементу слева
                }
            }
        }
        while (!added);
    }
}
