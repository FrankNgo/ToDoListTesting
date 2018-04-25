using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoList.Controllers;


namespace ToDoList.Tests.ControllerTests
{
    class ItemsControllerTest
    {

        [TestMethod]
        public void ItemsController_AddsItemToIndexModelData_Collection()
        {
            // Arrange
            ItemsController controller = new ItemsController();
            Item testItem = new Item();
            testItem.Description = "test item";

            // Act
            controller.Create(testItem);
            ViewResult indexView = new ItemsController().Index() as ViewResult;
            var collection = indexView.ViewData.Model as List<Item>;

            // Assert
            CollectionAssert.Contains(collection, testItem);
        }
    }
}
