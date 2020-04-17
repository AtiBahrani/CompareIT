using CompareIT_API.Model;
using CustomAPI_V4;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompareIT_API.Controllers
{
    [Route("api/TodoItems")]
    public class TodoItemsController
    {
        private readonly TodoContext context;
        private CompareIT compare = new CompareIT(); // connection to the tier2

        public TodoItemsController(TodoContext context)
        {
            this.context = context;
        }

        //GET by query string
        [HttpGet]
        public IEnumerable<FinalItem> GetItems(string title)
        {
            var result = compare.SortedPriceList(title);
            return result;
        }

        [HttpPost]
        public IEnumerable<FinalItem> GetItemsPost(string title)
        {
            var result = compare.SortedPriceList(title);
            return result;
        }

        /* later use:
        // POST: api/TodoItems
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            Console.WriteLine("Post here");
            context.TodoItems.Add(todoItem);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }*/
    }
}
