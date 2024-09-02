namespace Problem2 {

    public class ListNode {
        public int val;
        public ListNode? next;

        public ListNode(int[] vals)
        {
            this.val = vals[0];
            ListNode[] nodes = new ListNode[vals.Length];
            nodes[0] = this;
            for(int i=1; i<vals.Length; i++){
                ListNode newNode = new(vals[i]);
                nodes[i] = newNode;
                nodes[i-1].next = newNode;
            }
        }

        public ListNode(int val=0, ListNode? next = null) {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            return this.val.ToString() + 
                (this.next != null ? $",{this.next.ToString()}" : string.Empty);
        }
    }
 
    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            return AddTwoNumbers(l1, l2, 0);
        }

        private static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2, int carry)
        {
            ListNode result = new(0);
            int val1 = l1?.val ?? 0;
            int val2 = l2?.val ?? 0;
            int sum = val1 + val2 + carry;
            carry = 0;
            while (sum > 9) {
                carry++;
                sum-=10;
            }

            result.val = sum;
            if (l1?.next != null || l2?.next != null || carry > 0)
            {
                result.next = AddTwoNumbers(l1?.next, l2?.next, carry);
            }

            return result;
        }

        public void RunTests()
        {
            ListNode l1 = new([2,4,3]);
            ListNode l2 = new([5,6,4]);
            WriteResult(l1, l2, AddTwoNumbers(l1,l2));

            l1 = new(0);
            l2 = new(0);
            WriteResult(l1, l2, AddTwoNumbers(l1,l2));

            l1 = new([9,9,9,9,9,9,9]);
            l2 = new([9,9,9,9]);
            WriteResult(l1, l2, AddTwoNumbers(l1,l2));
        } 

        public static void WriteResult(ListNode l1, ListNode l2, ListNode result)
        {
            Console.WriteLine($"Input: l1 = [{l1.ToString()}], l2 = [{l2.ToString()}]");
            Console.WriteLine($"Output: [{result.ToString()}]");
            Console.WriteLine();
        }
    }
}