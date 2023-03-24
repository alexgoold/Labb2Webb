﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProductDataAccess.Models
{
	public class OrderModel
	{
		[BsonId]
		public ObjectId Id { get; set; }

		[BsonElement] 
		public CustomerModel Customer { get; set; }

		[BsonElement]
		public ProductModel[] Products { get; set; }

		[BsonElement]
		public DateTime DateOrdered { get; set; }


	}
}
