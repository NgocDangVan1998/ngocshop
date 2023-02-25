using NgocShop.Data.Infrastructure;
using NgocShop.Data.Repositories;
using NgocShop.Model.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgocShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize,out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int CategoryId,int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork) 
        {
            _postRepository = postRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id); 
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[]
            {
                "PostCategory"
            } );
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int CategoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x=>x.Status == true && x.CategoryID == CategoryId, out totalRow,page,pageSize,new string[] {"PostCategory"});
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTag(tag,page,pageSize,out totalRow);
        }

        public IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
