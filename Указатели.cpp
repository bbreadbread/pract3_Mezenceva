#include <iostream>
using namespace std;

struct Node {
    int data;
    Node* next;
    Node* prev;
};
 Node* list;
class DoublyLinkedList
{
private:
    Node* list = nullptr;
    Node* head = nullptr;
    Node* tail = nullptr;

    void find_head() {
        Node* current = tail;
        while (current->prev != nullptr) {
            current = current->prev;
        }
        head = current;
    }

    void find_tail() {
        Node* current = head;
        while (current->next != nullptr) {
            current = current->next;
        }
        tail = current;
    }
public:
    void push_front(int data) {
        if (list == nullptr) {
            list = new Node{ data, nullptr, nullptr };
            tail = list;
            head = list;
            return;
        }
        Node* current = list;
        while (current->prev != nullptr) {
            current = current->prev;
        }
        current->prev = new Node{ data, current, nullptr };
        current->prev->next = current;
        head = current->prev;
        if (tail == nullptr) tail = list;
    }

    void push_back(int data) {
        if (list == nullptr) {
            list = new Node{ data, nullptr, nullptr };
            tail = list;
            head = list;
            return;
        }
            Node* current = list;
            while (current->next != nullptr) {
                current = current->next;
            }
            current->next = new Node{ data, nullptr, current };
            current->next->prev = current;
            tail = current->next;
            if (head == nullptr) head = list;
        
    }

    void pop_front() {
        if (list == nullptr) {
            tail = nullptr;
            head = nullptr;
            return;
        }

        if (tail != head) {
            Node* current = head->next;
            if (list->prev == nullptr && list->next == nullptr) {
                list = nullptr;
            }
            else {
                if (current->prev == list) {
                    list = current;
                }
                current->prev = nullptr;
                head = current;
            }
        }
        else {
            list = tail = head = nullptr;
        }

    }

    void pop_back() {
        if (list == nullptr) {
            tail = nullptr;
            head = nullptr;
            return;
        }
        if (tail != head) {
            Node* current = tail->prev;
            if (list->prev == nullptr && list->next == nullptr) {
                list = nullptr;
            }
            else {
                if (current->next == list) {
                    list = current;
                }
                current->next = nullptr;
                tail = current;
            }
        }
        else {
            list = tail = head = nullptr;
        }

    }

    void display() {
        if (list == nullptr) {
           cout << "Пустой лист" << endl;
            tail = nullptr;
            head = nullptr;
            return;
        }
        Node* current = head;
        while (current != nullptr) {
             cout << current->data << " ";
            current = current->next;
        }
         cout <<  endl;

    }

    void sort() {
        if (list == nullptr) {
            tail = nullptr;
            head = nullptr;
            return;
        }
        Node* current = head->next;
        Node* end = nullptr;
        while (current != end) {
            if (current->data < current->prev->data) {
                int data = current->prev->data;
                current->prev->data = current->data;
                current->data = data;
            }
            if (current->next == end) {
                end = current;
                current = head;
            }
            current = current->next;
        }

    }



    void remove_duplicates() {
        if (list == nullptr) {
            tail = nullptr;
            head = nullptr;
            return;
        }
        Node* current = head;
        while (current != nullptr) {
            Node* temp = current;
            while (temp->next != nullptr) {
                if (temp->next->data == current->data) {
                    if (temp->next == list) {
                        list = temp;
                    }
                    Node* duplicate = temp->next;
                    temp->next = temp->next->next;

                    if (temp->next != nullptr)
                        temp->next->prev = temp;

                    delete duplicate;
                }
                else {
                    temp = temp->next;
                }
            }
            current = current->next;
        }
        find_tail();
    }
};

int main()
{
    setlocale(LC_ALL, "Russian");

    DoublyLinkedList list;
    setlocale(LC_ALL, "");
    while (true) {
        cout << "======================================" << endl;
        cout << "Добавить элемент в начало. Нажмите 1" << endl;
        cout << "Добавить элемент в конец.  Нажмите 2" << endl;
        cout << "Удалить элемент с начала. Нажмите 3" << endl;
        cout << "Удалить элемент с конца. Нажмите 4" << endl;
        cout << "Отобразить список. Нажмите 5" << endl;
        cout << "Сортировать список. Нажмите 6" << endl;
        cout << "Удалить дубликаты. Нажмите 7" << endl;
        cout << "Выйти. Нажмите любую клавишу." << endl;
        int number;
        cin >> number;
        switch (number)
        {
        case 1:
            cout << "Введите число" << endl;
            cin >> number;
            list.push_front(number);
            break;
        case 2:
            cout << "Введите число" << endl;
            cin >> number;
            list.push_back(number);
            break;
        case 3:
            list.pop_front();
            break;
        case 4:
            list.pop_back();
            break;
        case 5:
            list.display();
            break;
        case 6:
            list.sort();
            break;
        case 7:
            list.remove_duplicates();
            break;
        default:
            return 0;
            break;
        }
    }

    return 0;
}