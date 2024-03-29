using BookStoreServer.WebApi.Models;
using Iyzipay.Model;

namespace BookStoreServer.WebApi.Dtos;

public sealed record PaymentDto(
    List<Shoe> Shoes,
    Buyer Buyer,
    Address ShippingAddress,
    Address BillingAddress,
    PaymentCard PaymentCard,
    int? UserId
    );